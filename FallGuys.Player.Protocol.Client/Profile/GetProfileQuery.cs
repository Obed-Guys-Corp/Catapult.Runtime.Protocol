using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Profile;

[ProtoContract(Name = "FallGuys_Player_GetProfileQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetProfileQuery
{
}
