using System;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.RankedMode;

[ProtoContract(Name = "FallGuys_Player_RankedMode_RankedScoreChangesDto_V1")]
public class RankedScoreChangesDto
{
	[ProtoMember(1)]
	public int OriginalScore { get; set; }

	[ProtoMember(2)]
	public int Progress { get; set; }

	[ProtoMember(3)]
	public string? Chainkey { get; set; }

	[ProtoMember(4)]
	public DateTime? StartedAt { get; set; }
}
