using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Stats;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_GetPlayersStatsQuery_V1")]
public class GetPlayersStatsQuery
{
}
