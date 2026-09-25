using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Profile;

[ProtoContract(Name = "FallGuys_Player_UpdatePlayerNameCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class UpdatePlayerNameCommand
{
	[ProtoMember(1)]
	public string RandomNameToken { get; set; }
}
