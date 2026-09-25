using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[ProtoContract(Name = "FallGuys_Player_LiveEventMilestoneDto_V1")]
public class LiveEventMilestoneDto
{
    [ProtoMember(1)]
    public int XpRequired { get; set; }

    [ProtoMember(2)]
    public bool IsClaimed { get; set; }

    [ProtoMember(3)]
    public string? RewardItemId { get; set; }

    [ProtoMember(4)]
    public bool IsUnlocked { get; set; }

    [ProtoMember(5)]
    public int Index { get; set; }
}
