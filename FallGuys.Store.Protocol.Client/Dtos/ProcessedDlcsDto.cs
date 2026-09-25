using System.Collections.Generic;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_ProcessedDlcsDto_V1")]
public class ProcessedDlcsDto
{
	private List<ItemAddedDto>? _itemsAdded;

	private List<ItemRemovedDto>? _itemsRemoved;

	[ProtoMember(1)]
	public List<ItemAddedDto> ItemsAdded
	{
		get
		{
			return _itemsAdded ??= [];
		}
		set
		{
			_itemsAdded = value;
		}
	}

	[ProtoMember(2)]
	public List<ItemRemovedDto> ItemsRemoved
	{
		get
		{
			return _itemsRemoved ?? (_itemsRemoved = new List<ItemRemovedDto>());
		}
		set
		{
			_itemsRemoved = value;
		}
	}
}
