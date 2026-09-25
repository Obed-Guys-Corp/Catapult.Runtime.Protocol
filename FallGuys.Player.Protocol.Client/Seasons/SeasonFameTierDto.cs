using ProtoBuf;
using System;
using System.Collections.Generic;

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

    [Obsolete("please use Rewards")]
    [ProtoMember(4)]
    public string RewardId { get; set; } = null!;

    [ProtoMember(5)]
    public bool IsAcknowledged { get; set; }

    [ProtoMember(6)]
    public List<UnlockedRewardDto> UnlockedRewards { get; set; } = null!;

    [ProtoMember(7)]
    public List<LockedRewardDto> LockedRewards { get; set; } = null!;
}
