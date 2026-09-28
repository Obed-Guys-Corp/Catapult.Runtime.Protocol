using Catapult.Modules.Items.Protocol;
using Catapult.Protocol.Headers;
using Catapult.Protocol.Internal;
using Catapult.Protocol.Runtime.Attributes;
using Catapult.Protocol.Runtime.Serializers;
using Catapult.Protocol.Runtime.Serializers.Core;
using Catapult.Services.Gateway.Protocol.Client;
using Catapult.Services.Login.Protocol.Client;
using FallGuys.Client.Protocol;
using FallGuys.Common.Targeting.Protocol.Client;
using FallGuys.Gateway.Protocol.Client;
using FallGuys.Lobby.Protocol.Client;
using FallGuys.Lobby.Protocol.Common;
using FallGuys.Match.Protocol.Client;
using FallGuys.Player.Protocol.Client;
using FallGuys.Store.Protocol.Client;
using ProtoBuf;
using System.Buffers.Binary;
using System.Reflection;
using System.Text;
using static Catapult.Protocol.Runtime.Logger;

namespace Catapult.Protocol.Runtime
{
    public static class RuntimeProtocol
    {
        //this forces load of assemblies so they can be identified
        //i don't like this design in general and should probably move the whole identification process into the build process
        //cuz there's no reason to have it in runtime
        static readonly Assembly[] _assemblies = 
        [
            typeof(ItemsProtocolMarker).Assembly,
            typeof(NetworkingProtocolMarker).Assembly,
            typeof(CatapultGatewayProtocolMarker).Assembly,
            typeof(CatapultLoginProtocolMarker).Assembly,
            typeof(ClientProtocolMarker).Assembly,
            typeof(TargetingProtocolMarker).Assembly,
            typeof(GatewayProtocolMarker).Assembly,
            typeof(LobbyProtocolClientMarker).Assembly,
            typeof(LobbyProtocolCommonMarker).Assembly,
            typeof(MatchProtocolMarker).Assembly,
            typeof(PlayerProtocolMarker).Assembly,
            typeof(StoreProtocolMarker).Assembly,
        ];

        internal static readonly Dictionary<uint, Type> _knownMessages;

        static RuntimeProtocol()
        {
            _knownMessages = [];

            foreach (var asm in _assemblies)
            {
                foreach (var contract in asm.GetTypes().Where(t => t.GetCustomAttribute<ProtoContractAttribute>() != null))
                {
                    if (contract == typeof(Message) || contract == typeof(Message<>) || contract == typeof(Result<>)) continue;

                    var name = contract.GetCustomAttribute<ProtoContractAttribute>()!.Name;

                    if (string.IsNullOrEmpty(name))
                    {
                        LogLineWarn(typeof(RuntimeProtocol), $"Model {contract.Name} lacks {nameof(ProtoContractAttribute)} name, it CANNOT be used in messaging!!");
                        continue;
                    }

                    if (contract == typeof(Result) || typeof(MessageHeader).IsAssignableFrom(contract))
                    {
                        _knownMessages[MarkMessage(name)] = contract;
                        continue;
                    }

                    _knownMessages[MarkMessage(name)] = contract;

                    var msgName = typeof(Message<>).GetCustomAttribute<ProtoContractAttribute>()!.Name;
                    _knownMessages[MarkMessage(msgName + name)] = typeof(Message<>).MakeGenericType(contract);

                    var resName = typeof(Result<>).GetCustomAttribute<ProtoContractAttribute>()!.Name;
                    _knownMessages[MarkMessage(resName + name)] = typeof(Result<>).MakeGenericType(contract);
                }
            }

#if DEBUG
            foreach (var ms in _knownMessages)
                Console.WriteLine(ms.Key + " " + ms.Value);
#endif
        }

        public static Message? ReadMessage(MemoryStream stream) => ReadMessage(stream.ToArray());
        public static Message? ReadMessage(byte[] data)
        {
            if (data == null || data.Length == 0) return null!;

            try
            {
                using var reader = ProtoReader.Create(new MemoryStream(data, 0, data.Length), null, null);

                Message? res = null!;
                List<MessageHeader>? headers = null!;
                int f;

                while ((f = reader.ReadFieldHeader()) > 0)
                {
                    if (f == 1)
                    {
                        do
                        {
                            var mToken = ProtoReader.StartSubItem(reader);

                            int hField;
                            while ((hField = reader.ReadFieldHeader()) > 0)
                            {
                                if (!_knownMessages.TryGetValue((uint)hField, out var hType))
                                {
                                    LogLineWarn(typeof(RuntimeProtocol), $"Unknown message header with id={hField}");
                                    reader.SkipField();
                                    continue;
                                }

                                var headerSerializer = hType.GetCustomAttribute<SerializerAttribute>()?.Serializer ?? typeof(BasicSerializer);

                                var hToken = ProtoReader.StartSubItem(reader);
                                var header = SerializersInstances.Access(headerSerializer).Read(reader, hType);
                                ProtoReader.EndSubItem(hToken, reader);

                                if (header is MessageHeader h)
                                {
                                    headers ??= [];
                                    headers.Add(h);
                                }
                            }

                            ProtoReader.EndSubItem(mToken, reader);
                        }
                        while (reader.TryReadFieldHeader(1));

                        continue;
                    }

                    if (!_knownMessages.TryGetValue((uint)f, out var bType))
                    {
                        LogLineWarn(typeof(RuntimeProtocol), $"Unknown message body with id={f}");
                        reader.SkipField();
                        continue;
                    }

                    var bodySerializer = bType.GetCustomAttribute<SerializerAttribute>()?.Serializer ?? typeof(BasicSerializer);
                    var bToken = ProtoReader.StartSubItem(reader);

                    Message inst;

                    if (bType.IsGenericType)
                    {
                        var bodyType = bType.GetGenericArguments()[0];

                        int bField;
                        bool hasBody = false;
                        object? body = null;

                        while ((bField = reader.ReadFieldHeader()) > 0)
                        {
                            if (bField != 1)
                            {
                                reader.SkipField();
                                continue;
                            }

                            var bcToken = ProtoReader.StartSubItem(reader);
                            body = SerializersInstances.Access(bodySerializer).Read(reader, bodyType);
                            ProtoReader.EndSubItem(bcToken, reader);

                            hasBody = true;
                            break;
                        }

                        if (!hasBody)
                            body = Activator.CreateInstance(bodyType)!;

                        ProtoReader.EndSubItem(bToken, reader);

                        inst = (Message)Activator.CreateInstance(bType, body)!;
                    }
                    else
                    {
                        inst = (Message)SerializersInstances.Access(bodySerializer).Read(reader, bType);
                        ProtoReader.EndSubItem(bToken, reader);
                    }

                    res = inst;
                }

                res?.Headers = headers!;

                return res;
            }
            catch (Exception e)
            {
                LogLineError(typeof(RuntimeProtocol), $"Unable to read message!\n{e}");
                return null;
            }
        }


        public static byte[] CreateReply<T>(Result<T> response, Message replyTo) => GetReplyID(replyTo, out var id) ? CreateReply(response, id) : null!;
        public static byte[] CreateReply(Message response, Message replyTo) => GetReplyID(replyTo, out var id) ? CreateReply((dynamic)response, id) : null!;

        public static byte[] CreateReply<T>(Result<T> response, Guid replyId)
        {
            AttachReplyHeaders(response, replyId);

            return Write(response, writer =>
            {
                var bToken = WriteBody<T>(response.Body, typeof(Result<>), writer);
                WriteField(2, response.Error, writer);
                ProtoWriter.EndSubItem(bToken, writer);
            });
        }

        public static byte[] CreateReply(Result response, Guid replyId)
        {
            AttachReplyHeaders(response, replyId);

            return Write(response, writer =>
            {
                var bToken = WriteBody<Result>(null, null!, writer);
                WriteField(1, response.Error, writer);
                ProtoWriter.EndSubItem(bToken, writer);
            });
        }

        public static byte[] CreateReply(ErrorMessage response, Guid replyId)
        {
            AttachReplyHeaders(response, replyId);

            return Write(response, writer =>
            {
                var bToken = WriteBody<ErrorMessage>(null, null!, writer);
                WriteField(1, response.Error, writer);
                ProtoWriter.EndSubItem(bToken, writer);
            });
        }

        public static byte[] CreateMessage<T>(Message<T> message)
        {
            AttachRequestHeaders(message);

            return Write(message, writer =>
            {
                var bToken = WriteBody<T>(message.Body, typeof(Message<>), writer);
                ProtoWriter.EndSubItem(bToken, writer);
            }!);
        }

        public static byte[] CreateMessage(KeepAliveMessage message)
        {
            message.AttachHeader(new CorrelationHeader
            {
                ActivityId = Guid.NewGuid(),
            });

            message.AttachHeader(new OperationHeader
            {
                RequestId = Guid.NewGuid(),
                Type = OperationType.OneWay,
            });

            return Write(message, writer =>
            {
                var bToken = WriteBody<KeepAliveMessage>(null, null!, writer);
                ProtoWriter.EndSubItem(bToken, writer);
            }!);
        }

        private static byte[] Write(Message response, Action<ProtoWriter> doWrite)
        {
            using var ms = new MemoryStream();
           
            using (var writer = ProtoWriter.Create(ms, null, null))
            {
                doWrite(writer);
                WriteMessageHeaders(response.Headers, writer);
            }

            return ms.ToArray();
        }

        static bool GetReplyID(Message replyTo, out Guid id)
        {
            if (replyTo == null) throw new ArgumentNullException(nameof(replyTo), "Reply was null");

            id = Guid.Empty;
            if (replyTo.Headers == null || replyTo.Headers.Count == 0)
            {
                LogLineError(typeof(RuntimeProtocol), $"Attempt to reply to {replyTo.GetTypeName()} but message doesn't contain headers!");
                return false;
            }

            if (replyTo.TryGetHeader<OperationHeader>(out var h))
            {
                if (h.Type != OperationType.Request)
                    LogLineWarn(typeof(RuntimeProtocol), $"Attempt to reply to a message that is not a request but {h.Type} instead ({replyTo.GetTypeName()})! Is this intended?");

                id = h.RequestId;
            }

            return id != Guid.Empty;
        }

        static void AttachReplyHeaders(Message res, Guid id)
        {
            res.AttachHeader(new CorrelationHeader
            {
                ActivityId = Guid.NewGuid(),
            });

            res.AttachHeader(new OperationHeader
            {
                RequestId = id,
                Type = OperationType.Reply,
            });
        }

        static void AttachRequestHeaders(Message res)
        {
            res.AttachHeader(new CorrelationHeader
            {
                ActivityId = Guid.NewGuid(),
            });

            res.AttachHeader(new OperationHeader
            {
                RequestId = Guid.NewGuid(),
                Type = OperationType.Request,
            });
        }

        static void WriteMessageHeaders(List<MessageHeader> headers, ProtoWriter writer)
        {
            if (headers == null) return;

            foreach (var header in headers)
            {
                ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
                var fToken = ProtoWriter.StartSubItem(null, writer);

                var headerId = MarkMessage(header.GetType().GetCustomAttribute<ProtoContractAttribute>()?.Name!);
                if (!_knownMessages.TryGetValue(headerId, out var hType))
                    throw new InvalidOperationException($"Message header {header.GetType().Name} is not registred");

                var headerSerializer = (hType.GetCustomAttribute<SerializerAttribute>()?.Serializer) ?? typeof(BasicSerializer);

                ProtoWriter.WriteFieldHeader((int)headerId, WireType.String, writer);
                var hToken = ProtoWriter.StartSubItem(null, writer);
                SerializersInstances.Access(headerSerializer!).Write(header, writer);
                ProtoWriter.EndSubItem(hToken, writer);

                ProtoWriter.EndSubItem(fToken, writer);
            }
        }

        static void WriteField(int fNum, object? body, ProtoWriter writer)
        {
            if (body == null) return;

            var ser = body.GetType().GetCustomAttribute<SerializerAttribute>()?.Serializer ?? typeof(BasicSerializer);

            ProtoWriter.WriteFieldHeader(fNum, WireType.String, writer);

            var eToken = ProtoWriter.StartSubItem(body, writer);

            SerializersInstances.Access(ser).Write(body, writer);

            ProtoWriter.EndSubItem(eToken, writer);
        }

        static SubItemToken WriteBody<T>(object? body, Type msgIn, ProtoWriter writer)
        {
            var resultId = MarkMessage($"{(msgIn != null ? msgIn.GetCustomAttribute<ProtoContractAttribute>()?.Name : "")}{typeof(T).GetCustomAttribute<ProtoContractAttribute>()?.Name}");

            if (!_knownMessages.TryGetValue(resultId, out _))
                throw new InvalidOperationException($"Message body {typeof(T).Name} is not registred");

            ProtoWriter.WriteFieldHeader((int)resultId, WireType.String, writer);

            var bToken = ProtoWriter.StartSubItem(null, writer);

            if (body != null)
            {
                ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
                var cToken = ProtoWriter.StartSubItem(null, writer);

                var serializer = (typeof(T).GetCustomAttribute<SerializerAttribute>()?.Serializer) ?? typeof(BasicSerializer);

                SerializersInstances.Access(serializer).Write(body, writer);

                ProtoWriter.EndSubItem(cToken, writer);
            }

            return bToken;
        }

        internal static uint MarkMessage(string name)
        {
            var hash = System.IO.Hashing.Crc32.Hash(Encoding.UTF8.GetBytes(name));
            return BinaryPrimitives.ReadUInt32LittleEndian(hash) % 100000000;
        }
    }
}

