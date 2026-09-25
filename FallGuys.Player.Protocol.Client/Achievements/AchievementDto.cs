using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.Achievements;

[ProtoContract(Name = "FallGuys_Player_AchievementDto_V1")]
public class AchievementDto
{
    [ProtoMember(1)]
    public string Id { get; set; } = null!;

    [ProtoMember(2)]
    public string AchievementId { get; set; } = null!;

    [ProtoMember(3)]
    public DateTime? CompletedAt { get; set; }

    [ProtoMember(4)]
    public int Progress { get; set; }
}
