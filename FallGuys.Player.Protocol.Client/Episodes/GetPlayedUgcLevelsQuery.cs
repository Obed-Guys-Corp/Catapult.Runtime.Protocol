using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_GetPlayedUgcLevelsQuery_V1")]
public class GetPlayedUgcLevelsQuery
{
}
