using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "Catapult_Store_Protocol_PurchaseBundleCommand_PsnPayment_V1")]
public class PsnPaymentOption : PaymentOption
{
	[ProtoMember(1)]
	public string? ItemId { get; set; }

	[ProtoMember(2)]
	public string? AuthorizationCode { get; set; }

	[ProtoMember(3)]
	public ulong ServiceLabel { get; set; }

	[ProtoMember(4)]
	public int PsnEnvironment { get; set; }

	[ProtoMember(5)]
	public string? ProductId { get; set; }

	[ProtoMember(6)]
	public string? CurrencyCode { get; set; }
}
