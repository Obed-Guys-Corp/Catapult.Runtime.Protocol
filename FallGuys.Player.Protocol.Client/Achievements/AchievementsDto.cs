using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Achievements;

[ProtoContract(Name = "FallGuys_Player_AchievementsDto_V1")]
public class AchievementsDto
{
    private List<AchievementDto>? _achievements;

    [ProtoMember(1)]
    public List<AchievementDto> Achievements { get; set; }
}
