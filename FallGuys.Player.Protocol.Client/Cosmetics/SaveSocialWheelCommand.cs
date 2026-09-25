using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Cosmetics_SaveSocialWheelCommand_V1")]
public class SaveSocialWheelCommand
{
    [ProtoMember(1)]
    public SocialWheelDto? SocialWheel { get; set; }
}
