using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Profile;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_UpdatePlayerNameCommand_V1")]
public class UpdatePlayerNameCommand
{
    [ProtoMember(1)]
    public string RandomNameToken { get; set; } = null!;
}
