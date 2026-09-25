using ProtoBuf;

namespace FallGuys.Client.Protocol.Networking;

[ProtoContract(Name = "FallGuys_Networking_PollingStrategyType_V1")]
public enum PollingStrategyType
{
    [ProtoEnum(Name = "unknown")]
    Unknown,
    [ProtoEnum(Name = "poll")]
    Poll,
    [ProtoEnum(Name = "listen_then_poll")]
    ListenThenPoll
}
