using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking.Fn;

[ProtoContract(Name = "FallGuys_Matchmaking_SessionStartResult_V1")]
public enum SessionStartResult
{
    [ProtoEnum(Name = "unknown")]
    Unknown,
    [ProtoEnum(Name = "abandonment")]
    Abandonment,
    [ProtoEnum(Name = "failure")]
    Failure,
    [ProtoEnum(Name = "success")]
    Success
}
