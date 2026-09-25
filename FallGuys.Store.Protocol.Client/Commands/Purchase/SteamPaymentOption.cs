using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "Catapult_Store_Protocol_PurchaseBundleCommand_SteamPayment_V1")]
public class SteamPaymentOption : PaymentOption
{
	[ProtoMember(1)]
	public ulong OrderId { get; set; }

	[ProtoMember(2)]
	public ulong TransId { get; set; }

	[ProtoMember(3)]
	public ulong SteamId { get; set; }
}
