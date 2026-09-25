using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "Catapult_Store_Protocol_PurchaseBundleCommand_AppleReceiptPayment_V1")]
public class AppleReceiptPaymentOption : PaymentOption
{
	[ProtoMember(1)]
	public string? Receipt { get; set; }
}
