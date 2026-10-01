using ProtoBuf;

namespace Catapult.Runtime.Protocol.Serializers.Core
{
    internal interface ISerializer
    {
        object Read(ProtoReader reader, Type msg);
        void Write(object body, ProtoWriter writer);
    }

    internal interface ISerializer<TMsg> : ISerializer
    {
        new TMsg Read(ProtoReader reader, Type msg);
        void Write(TMsg body, ProtoWriter writer);
        void ISerializer.Write(object body, ProtoWriter writer) => Write((TMsg)body, writer);
        object ISerializer.Read(ProtoReader reader, Type msg) => Read(reader, msg)!;
    }
}
