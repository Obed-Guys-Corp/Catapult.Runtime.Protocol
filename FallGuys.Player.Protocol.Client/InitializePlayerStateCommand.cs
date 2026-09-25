using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client;

[ProtoContract(Name = "FallGuys_Profile_InitializePlayerStateCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class InitializePlayerStateCommand
{
}
