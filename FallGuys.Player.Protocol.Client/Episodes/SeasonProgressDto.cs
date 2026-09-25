using FallGuys.Player.Protocol.Client.Rewards;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_SeasonProgressDto_V1")]
public class SeasonProgressDto
{
    [Obsolete("please use UnclaimedFameTierRewards")]
    [ProtoMember(1)]
    public Dictionary<int, RewardDto> FameTiersUnlocked { get; set; } = null!;

    [ProtoMember(2)]
    public string SeasonId { get; set; } = null!;

    [ProtoMember(4)]
    public Dictionary<int, List<UnclaimedFameTierRewardDto>> UnclaimedFameTierRewards { get; set; } = null!;
}
