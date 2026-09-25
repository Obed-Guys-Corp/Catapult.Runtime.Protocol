using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Achievements;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_GetCompletedAchievementsQuery_V1")]
public class GetCompletedAchievementsQuery
{
}
