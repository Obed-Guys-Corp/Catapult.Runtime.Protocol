using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_ItemPaymentOptionDto_V1")]
public class ItemPaymentDto : PaymentDto
{
	private List<ItemPaymentLineDto>? _items;

	[ProtoMember(1)]
	public List<ItemPaymentLineDto> Items
	{
		get
		{
			return _items ?? (_items = new List<ItemPaymentLineDto>());
		}
		set
		{
			_items = value;
		}
	}
}
