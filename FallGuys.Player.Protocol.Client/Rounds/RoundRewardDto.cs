using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rounds;

[ProtoContract(Name = "FallGuys_Player_Rounds_RewardsEarned_V1")]
public class RoundRewardDto
{
    [ProtoMember(2)]
    public BonusDto? Bonus { get; set; }

    [ProtoMember(3)]
    public bool IsClaimed { get; set; }

    [ProtoMember(4)]
    public string? RewardId { get; set; }
}
