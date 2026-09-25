using Catapult.Modules.Items.Protocol.Dtos;
using FallGuys.Player.Protocol.Client.Rewards;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.RankedMode;

[ProtoContract(Name = "FallGuys_Player_RankedMode_ClaimedRankScoreRewardsDto_V1")]
public class ClaimedRankScoreRewardsDto
{
    private RewardDto[]? _earnedRewards;

    [ProtoMember(1)]
    [Obsolete("use EarnedRewardIds and claim rewards via GetUnclaimedRewardsQuery & ClaimRewardCommand")]
    public List<ItemAddedDto>? PreClaimedRewardItems { get; set; }

    [ProtoMember(2)]
    public RewardDto[] EarnedRewards { get; set; }
}
