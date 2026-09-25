using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.PlayerBoot;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_PlayerBootRequest_V1")]
public class PlayerBootRequest
{
}
