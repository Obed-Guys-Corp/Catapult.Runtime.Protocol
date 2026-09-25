using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_GetPlayedUgcLevelsQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetPlayedUgcLevelsQuery
{
}
