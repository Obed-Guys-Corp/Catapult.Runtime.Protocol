using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_StoreBundleRewardDto_V1")]
public class StoreBundleRewardDto
{
	private List<StoreBundleItemDto>? _items;

	[ProtoMember(1)]
	public List<StoreBundleItemDto> Items
	{
		get
		{
			return _items ?? (_items = new List<StoreBundleItemDto>());
		}
		set
		{
			_items = value;
		}
	}
}
