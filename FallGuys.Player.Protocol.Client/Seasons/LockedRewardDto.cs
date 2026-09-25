using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Seasons;

[ProtoContract(Name = "FallGuys_Player_SeasonFameTierLockedRewardDto_V1")]
public class LockedRewardDto
{
    [ProtoMember(1)]
    public string? RewardContentId { get; set; }

    [ProtoMember(2)]
    public string? SeasonPassContentId { get; set; }
}
