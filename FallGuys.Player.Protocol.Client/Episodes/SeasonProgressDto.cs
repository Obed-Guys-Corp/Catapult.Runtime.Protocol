using System;
using System.Collections.Generic;
using FallGuys.Player.Protocol.Client.Rewards;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_SeasonProgressDto_V1")]
public class SeasonProgressDto
{
	[ProtoMember(1)]
	[Obsolete("please use UnclaimedFameTierRewards")]
	public Dictionary<int, RewardDto> FameTiersUnlocked { get; set; } = new Dictionary<int, RewardDto>();

	[ProtoMember(2)]
	public string SeasonId { get; set; }

	[ProtoMember(4)]
	public Dictionary<int, List<UnclaimedFameTierRewardDto>> UnclaimedFameTierRewards { get; set; } = new Dictionary<int, List<UnclaimedFameTierRewardDto>>();
}
