using Catapult.Protocol.Custom.Attributes;
using Catapult.Protocol.Custom.Serializers;
using Catapult.Protocol.Custom.Serializers.Core;
using Catapult.Protocol.Headers;
using Catapult.Protocol.Internal;
using ProtoBuf;
using System.Buffers.Binary;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using static Logger.Logger;

namespace Catapult.Protocol.Custom
{
    public static class Protocol
    {
        static readonly Dictionary<uint, Type> KnownMessages;

        static Protocol()
        {
            KnownMessages = [];

            foreach (var contract in Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetCustomAttribute<ProtoContractAttribute>() != null))
            {
                if (contract == typeof(Message) || contract == typeof(Message<>) || contract == typeof(Result<>)) continue;

                var name = contract.GetCustomAttribute<ProtoContractAttribute>()!.Name;

                if (string.IsNullOrEmpty(name))
                {
                    LogLineWarn(typeof(Protocol), $"Model {contract.Name} lacks {nameof(ProtoContractAttribute)} name, it CANNOT be used in messaging!!");
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

            foreach (var ms in KnownMessages)
                Console.WriteLine(ms.Key + " " + ms.Value);
        }

        public static Message? ReadMessage(byte[] data)
        {
            if (data == null || data.Length == 0) return null!;

            try
            {
                using var reader = new ProtoReader(new MemoryStream(data, 0, data.Length), null, null);

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
                                    LogLineWarn(typeof(Protocol), $"Unknown message header with id={f}");
                                    reader.SkipField();
                                    continue;
                                }

                                var headerSerializer = (hType.GetCustomAttribute<SerializerAttribute>()?.Serializer) ?? typeof(BasicSerializer);

                                var hToken = ProtoReader.StartSubItem(reader);
                                var header = SerializersInstances.Access(headerSerializer).Read(reader, hType);

                                var h = header as MessageHeader;
                                if (res != null)
                                    res.AttachHeader(h);
                                else
                                {
                                    headers ??= [];
                                    headers.Add(h!);
                                }

                                ProtoReader.EndSubItem(hToken, reader);
                            }

                            ProtoReader.EndSubItem(mToken, reader);

                        } while (reader.TryReadFieldHeader(1));

                        continue;
                    }

                    if (!KnownMessages.TryGetValue((uint)f, out var bType))
                    {
                        LogLineWarn(typeof(Protocol), $"Unknown message with id={f}");
                        reader.SkipField();
                        continue;
                    }

                    Console.WriteLine(f);
                    Console.WriteLine(bType);

                    var bToken = ProtoReader.StartSubItem(reader);
                    int bField;

                    object inst = null!;
                    bool hasBody = false;

                    while ((bField = reader.ReadFieldHeader()) > 0)
                    {
                        if (bField == 1)
                        {
                            var bcToken = ProtoReader.StartSubItem(reader);

                            var bodySerializer = (bType.GetCustomAttribute<SerializerAttribute>()?.Serializer) ?? typeof(BasicSerializer);

                            inst = SerializersInstances.Access(bodySerializer!).Read(reader, bType.IsGenericType ? bType.GetGenericArguments()[0] : bType);

                            hasBody = true;
                            ProtoReader.EndSubItem(bcToken, reader);
                        }
                        else
                        {
                            reader.SkipField();
                        }
                    }

                    if (!hasBody)
                        inst = Activator.CreateInstance(bType)!;

                    ProtoReader.EndSubItem(bToken, reader);

                    if (inst is Message msgInst)
                        res = msgInst;
                    else
                        res = new Message<object>(inst);

                    if (headers != null)
                    {
                        foreach (var h in headers) res.AttachHeader(h);
                        headers = null!;
                    }
                }
                return res;
            }
            catch (Exception e)
            {
                LogLineError(typeof(Protocol), $"Unable to read message!\n{e}");
                return null!;
            }
        }

        public static byte[] ReplyToMessage<T>(Result<T> response, Message replyTo) => GetReplyID(replyTo, out var id) ? ReplyToMessage(response, id) : null!;
        public static byte[] ReplyToMessage(Message response, Message replyTo) => GetReplyID(replyTo, out var id) ? ReplyToMessage((dynamic)response, id) : null!;

        public static byte[] ReplyToMessage<T>(Result<T> response, Guid replyId)
        {
            return WriteReplyBytes(response, replyId, writer =>
            {
                var bToken = WriteResultBody<T>(response.Body, writer);
                WriteResultError(response.Error, 2, writer);
                ProtoWriter.EndSubItem(bToken, writer);
            });
        }

        public static byte[] ReplyToMessage(Result response, Guid replyId)
        {
            return WriteReplyBytes(response, replyId, writer =>
            {
                var bToken = WriteResultBody<Result>(null, writer);
                WriteResultError(response.Error, 1, writer);
                ProtoWriter.EndSubItem(bToken, writer);
            });
        }

        public static byte[] ReplyToMessage(ErrorMessage response, Guid replyId)
        {
            return WriteReplyBytes(response, replyId, writer =>
            {
                var bToken = WriteResultBody<ErrorMessage>(null, writer);
                WriteResultError(response.Error, 1, writer);
                ProtoWriter.EndSubItem(bToken, writer);
            });
        }

        private static byte[] WriteReplyBytes(Message response, Guid replyId, Action<ProtoWriter> doWrite)
        {
            AttachReplyHeaders(response, replyId);

            using var ms = new MemoryStream();
            using (var writer = new ProtoWriter(ms, null, null))
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
                LogLineError(typeof(Protocol), $"Attempt to reply to {replyTo.GetTypeName()} but message doesn't contain headers!");
                return false;
            }

            if (replyTo.TryGetHeader<OperationHeader>(out var h))
            {
                if (h.Type != OperationType.Request)
                    LogLineWarn(typeof(Protocol), $"Attempt to reply to a message that is not a request but {h.Type} instead ({replyTo.GetTypeName()})! Is this intended?");

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

        static void WriteMessageHeaders(List<MessageHeader> headers, ProtoWriter writer)
        {
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

        static void WriteResultError(object? error, int fNum, ProtoWriter writer)
        {
            if (error == null) return;

            var ser = error.GetType().GetCustomAttribute<SerializerAttribute>()?.Serializer ?? typeof(BasicSerializer);

            ProtoWriter.WriteFieldHeader(fNum, WireType.String, writer);
            var eToken = ProtoWriter.StartSubItem(error, writer);

            SerializersInstances.Access(ser).Write(error, writer);

            ProtoWriter.EndSubItem(eToken, writer);
        }

        static SubItemToken WriteResultBody<T>(object? body, ProtoWriter writer)
        {
            var resultId = MarkMessage($"{(body != null ? typeof(Result<>).GetCustomAttribute<ProtoContractAttribute>()?.Name : "")}{typeof(T).GetCustomAttribute<ProtoContractAttribute>()?.Name}");
            
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

