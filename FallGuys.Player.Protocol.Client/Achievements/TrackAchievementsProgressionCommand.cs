using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Achievements;

[ProtoContract(Name = "FallGuys_Player_TrackAchievementsProgressionCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class TrackAchievementsProgressionCommand
{
    private List<AchievementProgressDto>? _achievementProgressList;

    [ProtoMember(1)]
    public List<AchievementProgressDto> AchievementProgressList { get; set; }
}
