using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Achievements;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_GetAchievementsQuery_V1")]
public class GetAchievementsQuery
{
}
