using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Achievements;

[ProtoContract(Name = "FallGuys_Player_AchievementsCompletedNotificationDto_V1")]
public class AchievementsCompletedNotificationDto
{
    [ProtoMember(1)]
    public string Id { get; set; } = null!;

    [ProtoMember(2)]
    public List<AchievementDto> Achievements { get; set; } = null!;
}
