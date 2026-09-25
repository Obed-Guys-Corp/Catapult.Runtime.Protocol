using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Rewards;

[ProtoContract(Name = "FallGuys_Client_ClaimedRewardsDto_V1")]
public class ClaimedRewardsDto
{
    [ProtoMember(1)]
    public Dictionary<string, RewardClaimedDto> ClaimedRewards { get; set; } = null!;

    [ProtoMember(2)]
    public UnclaimedRewardsDto? UnclaimedRewards { get; set; }
}
