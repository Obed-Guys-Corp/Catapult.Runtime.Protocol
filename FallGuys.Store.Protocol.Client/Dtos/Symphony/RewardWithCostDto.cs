using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_RewardWithCostDto_V1")]
public class RewardWithCostDto
{
    [ProtoMember(1)]
    public int Cost { get; set; }

    [ProtoMember(2)]
    public SymphonyStoreBundleRewardDto? Reward { get; set; }

    [ProtoMember(3)]
    public bool AlreadyOwned { get; set; }
}
