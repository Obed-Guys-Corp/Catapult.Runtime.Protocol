using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Achievements;

[ProtoContract(Name = "FallGuys_Player_GetCompletedAchievementsQuery_V1")]
[Authorize(Roles = new string[] { "User" })]
public class GetCompletedAchievementsQuery
{
}
