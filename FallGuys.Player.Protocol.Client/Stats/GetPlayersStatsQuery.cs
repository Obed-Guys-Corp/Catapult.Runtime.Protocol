using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Stats;

[ProtoContract(Name = "FallGuys_Player_GetPlayersStatsQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetPlayersStatsQuery
{
}
