using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rounds;

[ProtoContract(Name = "FallGuys_Player_Rounds_Bonus_V1")]
public class BonusDto
{
    [ProtoMember(1)]
    public string? BadgeId { get; set; }

    [ProtoMember(2)]
    public int? BonusTierIndex { get; set; }
}
