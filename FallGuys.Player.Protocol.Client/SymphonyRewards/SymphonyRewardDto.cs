using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.SymphonyRewards;

[ProtoContract(Name = "FallGuys_SymphonyRewardDto_V1")]
public class SymphonyRewardDto
{
    [ProtoMember(1)]
    public string? SymphonyRewardId { get; set; }

    [ProtoMember(2)]
    public DateTime EarnedAt { get; set; }

    [ProtoMember(3)]
    public bool IsClaimed { get; set; }
}
