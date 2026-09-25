using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "Catapult_Store_PurchaseBundleCommand_V2")]
public class PurchaseBundleCommand
{
	[ProtoMember(1)]
	public PaymentOption? Payment { get; set; }
}
