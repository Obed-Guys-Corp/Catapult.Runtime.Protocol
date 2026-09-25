using ProtoBuf;

namespace FallGuys.Match.Protocol.Client.MatchStatus;

[ProtoContract(Name = "FallGuys_Match_MatchStatus_V1")]
public enum MatchStatus
{
	[ProtoEnum(Name = "unknown")]
	Unknown,
	[ProtoEnum(Name = "pending")]
	Pending,
	[ProtoEnum(Name = "ready")]
	Ready
}
