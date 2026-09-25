using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[ProtoContract(Name = "FallGuys_Player_GrantAllCosmeticsToPlayerCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GrantAllCosmeticsToPlayerCommand
{
    [ProtoMember(1)]
    public string PlayerId { get; set; }
}
