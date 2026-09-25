using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.PlayerLevel;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_GetPlayerLevelQuery_V1")]
public class GetPlayerLevelQuery
{
}
