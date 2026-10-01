using Catapult.Modules.Items.Protocol;
using Catapult.Protocol;
using Catapult.Protocol.Headers;
using Catapult.Protocol.Internal;
using Catapult.Runtime.Protocol.Attributes;
using Catapult.Runtime.Protocol.Serializers;
using Catapult.Runtime.Protocol.Serializers.Core;
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

namespace Catapult.Runtime.Protocol
{
    /// <summary>
    /// Provides basic operations for reading and writing protobuf messages at runtime
    /// </summary>
    public static class RuntimeProtocol
    {
        //this forces load of assemblies so messages in them can be identified
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

        internal static Dictionary<uint, Type>? KnownMessages;
        internal static bool VerboseLog;
        
        /// <summary>
        /// Initializes protobuf message ids 
        /// </summary>
        /// <param name="verbose">Verbose logs</param>
        public static void Initialize(bool verbose = false)
        {
            KnownMessages = [];
            VerboseLog = verbose;

            foreach (var asm in _assemblies)
            {
                foreach (var contract in asm.GetTypes().Where(t => t.GetCustomAttribute<ProtoContractAttribute>() != null))
                {
                    if (contract == typeof(Message) || contract == typeof(Message<>) || contract == typeof(Result<>)) continue;

                    var name = contract.GetCustomAttribute<ProtoContractAttribute>()!.Name;

                    if (string.IsNullOrEmpty(name))
                    {
                        if (VerboseLog) Console.WriteLine($"[{typeof(RuntimeProtocol).Name}] Model {contract.Name} lacks {nameof(ProtoContractAttribute)} name, it CANNOT be used in messaging!!");
                        continue;
                    }

                    if (contract == typeof(Result) || typeof(MessageHeader).IsAssignableFrom(contract))
                    {
                        KnownMessages[MarkMessage(name)] = contract;
                        continue;
                    }

                    KnownMessages[MarkMessage(name)] = contract;

                    var msgName = typeof(Message<>).GetCustomAttribute<ProtoContractAttribute>()!.Name;
                    KnownMessages[MarkMessage(msgName + name)] = typeof(Message<>).MakeGenericType(contract);

                    var resName = typeof(Result<>).GetCustomAttribute<ProtoContractAttribute>()!.Name;
                    KnownMessages[MarkMessage(resName + name)] = typeof(Result<>).MakeGenericType(contract);
                }
            }

#if DEBUG
            foreach (var ms in KnownMessages)
                Console.WriteLine(ms.Key + " " + ms.Value);
#endif
        }

        /// <summary>
        /// Reads protobuf bytes from <see cref="MemoryStream"/> and deserializes them into a <see cref="Message"/> object
        /// </summary>
        /// <param name="stream"><see cref="MemoryStream"/> that contains protobuf bytes</param>
        /// <returns><see cref="Message"/> object that represents actual message</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Message? ReadMessage(MemoryStream stream) => ReadMessage(stream.ToArray());

        /// <summary>
        /// Reads protobuf bytes and deserializes them into a <see cref="Message"/> object
        /// </summary>
        /// <param name="message"></param>
        /// <returns><see cref="Message"/> object that represents actual message</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Message? ReadMessage(byte[] message)
        {
            if (KnownMessages == null || KnownMessages.Count == 0) throw new InvalidOperationException($"{nameof(KnownMessages)} is not initialized!");

            if (message == null || message.Length == 0) return null!;

            try
            {
                using var reader = ProtoReader.Create(new MemoryStream(message, 0, message.Length), null, null);

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
                                if (!KnownMessages.TryGetValue((uint)hField, out var hType))
                                {
                                    if (VerboseLog) Console.WriteLine($"[{typeof(RuntimeProtocol).Name}] Unknown message header with id={hField}");
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

                    if (!KnownMessages.TryGetValue((uint)f, out var bType))
                    {
                        if (VerboseLog) Console.WriteLine($"[{typeof(RuntimeProtocol).Name}] Unknown message body with id={f}");
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
                if (VerboseLog) Console.WriteLine($"[{typeof(RuntimeProtocol).Name}] Unable to read message!\n{e}");
                return null;
            }
        }

        /// <summary>
        /// Writes <see cref="Result{TResultMessage}"/> protobuf bytes
        /// </summary>
        /// <typeparam name="TResultMessage">The type of the result body</typeparam>
        /// <param name="response"></param>
        /// <param name="replyTo"><see cref="Message"/> that represent request</param>
        /// <returns>Protobuf bytes that represent <see cref="Result{TResultMessage}"/> object</returns>
        public static byte[] CreateReply<TResultMessage>(Result<TResultMessage> response, Message replyTo) => GetReplyID(replyTo, out var id) ? CreateReply(response, id) : null!;

        /// <summary>
        /// Writes <see cref="Message"/> protobuf bytes
        /// </summary>
        /// <param name="response"></param>
        /// <param name="replyTo"><see cref="Message"/> that represent request</param>
        /// <returns>Protobuf bytes that represent <see cref="Message"/> object</returns>
        public static byte[] CreateReply(Message response, Message replyTo) => GetReplyID(replyTo, out var id) ? CreateReply((dynamic)response, id) : null!;

        /// <summary>
        /// Writes <see cref="ErrorMessage"/> protobuf bytes
        /// </summary>
        /// <param name="response"></param>
        /// <param name="replyTo"><see cref="Message"/> that represent request</param>
        /// <returns>Protobuf bytes that represent <see cref="ErrorMessage"/> object</returns>
        public static byte[] CreateReply(ErrorMessage response, Message replyTo) => GetReplyID(replyTo, out var id) ? CreateReply(response, id) : null!;

        /// <summary>
        /// Writes <see cref="Result{TResultMessage}"/> protobuf bytes
        /// </summary>
        /// <typeparam name="TResultMessage">The type of the result body</typeparam>
        /// <param name="response"></param>
        /// <param name="replyId">ID of request from <see cref="OperationHeader"/></param>
        /// <returns>Protobuf bytes that represent <see cref="Result{TResultMessage}"/> object</returns>
        public static byte[] CreateReply<TResultMessage>(Result<TResultMessage> response, Guid replyId)
        {
            AttachReplyHeaders(response, replyId);

            return Write(response, writer =>
            {
                var bToken = WriteBody<TResultMessage>(response.Body, typeof(Result<TResultMessage>), writer);
                WriteField(2, response.Error, writer);
                ProtoWriter.EndSubItem(bToken, writer);
            });
        }

        /// <summary>
        /// Writes <see cref="Result"/> protobuf bytes
        /// </summary>
        /// <param name="response"></param>
        /// <param name="replyId">ID of request from <see cref="OperationHeader"/></param>
        /// <returns>Protobuf bytes that represent <see cref="Result"/> object</returns>
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

        /// <summary>
        /// Writes <see cref="ErrorMessage"/> protobuf bytes
        /// </summary>
        /// <param name="response"></param>
        /// <param name="replyId">ID of request from <see cref="OperationHeader"/></param>
        /// <returns>Protobuf bytes that represent <see cref="ErrorMessage"/> object</returns>
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

        /// <summary>
        /// Writes <see cref="Message{TBody}"/> protobuf bytes
        /// </summary>
        /// <typeparam name="TBody">The type of the message body</typeparam>
        /// <param name="message"></param>
        /// <returns>Protobuf bytes that represent <see cref="Message{TBody}"/> object</returns>
        public static byte[] CreateMessage<TBody>(Message<TBody> message)
        {
            AttachRequestHeaders(message);

            return Write(message, writer =>
            {
                var bToken = WriteBody<TBody>(message.Body, typeof(Message<>), writer);
                ProtoWriter.EndSubItem(bToken, writer);
            }!);
        }

        /// <summary>
        /// Writes <see cref="KeepAliveMessage"/> protobuf bytes
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Protobuf bytes that represent <see cref="KeepAliveMessage"/> object</returns>
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

        static byte[] Write(Message response, Action<ProtoWriter> doWrite)
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
                if (VerboseLog) Console.WriteLine($"[{typeof(RuntimeProtocol).Name}] Attempt to reply to {replyTo.GetTypeName()} but message doesn't contain headers!");
                return false;
            }

            if (replyTo.TryGetHeader<OperationHeader>(out var h))
            {
                if (h.Type != OperationType.Request)
                    if (VerboseLog) Console.WriteLine($"[{typeof(RuntimeProtocol).Name}] Attempt to reply to a message that is not a request but {h.Type} instead ({replyTo.GetTypeName()})! Is this intended?");

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
            if (KnownMessages == null || KnownMessages.Count == 0) throw new InvalidOperationException($"{nameof(KnownMessages)} is not initialized!");

            if (headers == null) return;

            foreach (var header in headers)
            {
                ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
                var fToken = ProtoWriter.StartSubItem(null, writer);

                var headerId = MarkMessage(header.GetType().GetCustomAttribute<ProtoContractAttribute>()?.Name!);
                if (!KnownMessages.TryGetValue(headerId, out var hType))
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
            if (KnownMessages == null || KnownMessages.Count == 0) throw new InvalidOperationException($"{nameof(KnownMessages)} is not initialized!");

            var resultId = MarkMessage($"{(msgIn != null ? msgIn.GetCustomAttribute<ProtoContractAttribute>()?.Name : "")}{typeof(T).GetCustomAttribute<ProtoContractAttribute>()?.Name}");

            if (!KnownMessages.TryGetValue(resultId, out _))
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

