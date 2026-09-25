using ProtoBuf;

namespace Catapult.Protocol.Internal;

[ProtoContract(Name = "Catapult_Heartbeat_V1")]
public sealed class Heartbeat : Message
{
}
