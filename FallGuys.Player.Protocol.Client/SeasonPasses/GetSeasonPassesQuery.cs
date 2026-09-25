using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.SeasonPasses;

[ProtoContract(Name = "FallGuys_Player_GetSeasonPassesQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetSeasonPassesQuery
{
}
