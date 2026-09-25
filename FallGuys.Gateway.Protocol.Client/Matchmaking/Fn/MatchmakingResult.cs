using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking.Fn;

[ProtoContract(Name = "FallGuys_Matchmaking_MatchmakingResult_V1")]
public enum MatchmakingResult
{
	[ProtoEnum(Name = "unknown")]
	Unknown,
	[ProtoEnum(Name = "abandonment")]
	Abandonment,
	[ProtoEnum(Name = "timeout")]
	Timeout,
	[ProtoEnum(Name = "failure")]
	Failure,
	[ProtoEnum(Name = "success")]
	Success
}
