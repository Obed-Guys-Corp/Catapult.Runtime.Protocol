using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "FallGuys_Store_PurchaseSymphonyBundleCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class PurchaseSymphonyBundleCommand
{
	[ProtoMember(1)]
	public PaymentOption? Payment { get; set; }

	[ProtoMember(2)]
	public string? StoreSessionId { get; set; }

	[ProtoMember(3)]
	public string? ScreenId { get; set; }

	[ProtoMember(4)]
	public string? EntryPoint { get; set; }

	[ProtoMember(5)]
	public string? CostDisplayLocal { get; set; }

	[ProtoMember(6)]
	public string? CostUsd { get; set; }

	[ProtoMember(7)]
	public string? CurrencyCodeDisplayLocal { get; set; }
}
