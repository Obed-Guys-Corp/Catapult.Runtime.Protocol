using ProtoBuf;

namespace FallGuys.Player.Protocol.Client;

[ProtoContract(Name = "FallGuys_Player_RoundCompletionState_V1")]
public enum RoundCompletionState
{
    [ProtoEnum(Name = "unknown")]
    Unknown,
    [ProtoEnum(Name = "qualified")]
    Qualified,
    [ProtoEnum(Name = "disqualified")]
    Disqualified,
    [ProtoEnum(Name = "skipped")]
    Skipped
}
