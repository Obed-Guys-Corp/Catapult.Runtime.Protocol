using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Profile_InitializePlayerStateCommand_V1")]
public class InitializePlayerStateCommand
{
}
