using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.PurchaseHistory.Command;

[ProtoContract(Name = "FallGuys_ReturnPurchaseCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class ReturnPurchaseCommand
{
    [ProtoMember(1)]
    public string? BundleId { get; set; }
}
