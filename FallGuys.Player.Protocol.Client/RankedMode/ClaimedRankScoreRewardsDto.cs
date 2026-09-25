using System.Collections.Generic;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.RankedMode;

[ProtoContract(Name = "FallGuys_Player_RankedMode_ClaimedRankScoreRewardsDto_V1")]
public class ClaimedRankScoreRewardsDto
{
	[ProtoMember(1)]
	public List<ItemAddedDto>? Rewards { get; set; }
}
