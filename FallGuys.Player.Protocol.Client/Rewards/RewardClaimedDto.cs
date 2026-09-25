using System.Collections.Generic;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rewards;

[ProtoContract(Name = "FallGuys_Player_RewardClaimedDto_V1")]
public class RewardClaimedDto
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
