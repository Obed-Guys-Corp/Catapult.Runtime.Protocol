using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.AmazonEntitlements;

[ProtoContract(Name = "FallGuys_Player_CheckAmazonEntitlementsCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class CheckAmazonEntitlementsCommand
{
}
