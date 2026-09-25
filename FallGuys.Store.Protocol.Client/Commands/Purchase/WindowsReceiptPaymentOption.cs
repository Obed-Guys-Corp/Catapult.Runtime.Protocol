using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "Catapult_Store_Protocol_PurchaseBundleCommand_WindowsReceiptPayment_V1")]
public class WindowsReceiptPaymentOption : PaymentOption
{
	[ProtoMember(1)]
	public string? Receipt { get; set; }
}
