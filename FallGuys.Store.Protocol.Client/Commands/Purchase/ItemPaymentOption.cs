using System;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "Catapult_Store_PurchaseBundleCommand_ItemPaymentOption_V2")]
public class ItemPaymentOption : PaymentOption
{
	private ItemPaymentLine[]? _lines;

	[ProtoMember(1)]
	public string? StoreId { get; set; }

	[ProtoMember(2)]
	public string? StoreSectionId { get; set; }

	[ProtoMember(3)]
	public string? StoreBundleId { get; set; }

	[ProtoMember(4)]
	public ItemPaymentLine[] Lines
	{
		get
		{
			return _lines ?? (_lines = Array.Empty<ItemPaymentLine>());
		}
		set
		{
			_lines = value;
		}
	}
}
