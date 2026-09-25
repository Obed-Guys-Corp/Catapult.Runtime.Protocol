using System.Collections.Generic;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Entitlements;

[ProtoContract(Name = "FallGuys_Gateway_EntitlementsSyncResult_V1")]
public class SyncEntitlementsResult
{
	private List<ItemAddedDto>? _itemsGained;

	private List<ItemRemovedDto>? _itemsLost;

	[ProtoMember(1)]
	public List<ItemAddedDto> ItemsGained
	{
		get
		{
			return _itemsGained ?? (_itemsGained = new List<ItemAddedDto>());
		}
		set
		{
			_itemsGained = value;
		}
	}

	[ProtoMember(2)]
	public List<ItemRemovedDto> ItemsLost
	{
		get
		{
			return _itemsLost ?? (_itemsLost = new List<ItemRemovedDto>());
		}
		set
		{
			_itemsLost = value;
		}
	}
}
