using System.Collections.Generic;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_CompletedPurchaseDto_V1")]
public class CompletedPurchaseDto
{
	private List<ItemAddedDto>? _items;

	private List<StoreBundleDto>? _purchasedBundles;

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
	public List<StoreBundleDto> PurchasedBundles
	{
		get
		{
			return _purchasedBundles ?? (_purchasedBundles = new List<StoreBundleDto>());
		}
		set
		{
			_purchasedBundles = value;
		}
	}
}
