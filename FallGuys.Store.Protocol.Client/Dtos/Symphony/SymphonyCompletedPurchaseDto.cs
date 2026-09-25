using System.Collections.Generic;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_SymphonyCompletedPurchaseDto_V1")]
public class SymphonyCompletedPurchaseDto
{
	private List<ItemAddedDto>? _items;

	private List<SymphonyStoreBundleDto>? _purchasedBundles;

	[ProtoMember(1)]
	public List<ItemAddedDto> Items
	{
		get
		{
			return _items ?? (_items = new List<ItemAddedDto>());
		}
		set
		{
			_items = value;
		}
	}

	[ProtoMember(2)]
	public List<SymphonyStoreBundleDto> PurchasedBundles
	{
		get
		{
			return _purchasedBundles ?? (_purchasedBundles = new List<SymphonyStoreBundleDto>());
		}
		set
		{
			_purchasedBundles = value;
		}
	}
}
