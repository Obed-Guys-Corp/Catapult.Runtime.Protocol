using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.PlayerBoot;

[ProtoContract(Name = "FallGuys_Player_PlayerBootRequest_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class PlayerBootRequest
{
}
