using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Seasons;

[ProtoContract(Name = "FallGuys_Player_GetPlayerSeasonQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetPlayerSeasonQuery
{
}
