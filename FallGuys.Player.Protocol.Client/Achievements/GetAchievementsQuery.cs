using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Achievements;

[ProtoContract(Name = "FallGuys_Player_GetAchievementsQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetAchievementsQuery
{
}
