using System;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.RankedMode;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_RankedMode_ClaimRankedScoreRewardsCommand_V1")]
public class ClaimRankedScoreRewardsCommand
{
	[ProtoMember(1)]
	public string? RankingCycleChainkey { get; set; }

	[ProtoMember(2)]
	public DateTime? StartedAt { get; set; }
}
