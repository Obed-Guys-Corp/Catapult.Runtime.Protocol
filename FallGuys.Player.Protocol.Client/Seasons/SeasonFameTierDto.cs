using System;
using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Seasons;

[ProtoContract(Name = "FallGuys_Player_SeasonFameTierDto_V2")]
public class SeasonFameTierDto
{
	[ProtoMember(1)]
	public int Index { get; set; }

	[ProtoMember(2)]
	public int FameRequired { get; set; }

	[ProtoMember(3)]
	public bool IsUnlocked { get; set; }

	[ProtoMember(4)]
	[Obsolete("please use Rewards")]
	public string RewardId { get; set; }

	[ProtoMember(5)]
	public bool IsAcknowledged { get; set; }

	[ProtoMember(6)]
	public List<UnlockedRewardDto> UnlockedRewards { get; set; }

	[ProtoMember(7)]
	public List<LockedRewardDto> LockedRewards { get; set; }
}
