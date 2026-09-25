using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Achievements;

[ProtoContract(Name = "FallGuys_Player_AchievementProgressDto_V1")]
public class AchievementProgressDto
{
    [ProtoMember(1)]
    public string AchievementId { get; set; } = null!;

    [ProtoMember(2)]
    public int Increment { get; set; }
}
