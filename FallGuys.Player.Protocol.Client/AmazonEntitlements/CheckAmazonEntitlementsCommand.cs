using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.AmazonEntitlements;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_CheckAmazonEntitlementsCommand_V1")]
public class CheckAmazonEntitlementsCommand
{
}
