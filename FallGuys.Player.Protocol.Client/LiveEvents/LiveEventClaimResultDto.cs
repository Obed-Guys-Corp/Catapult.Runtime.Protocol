using System;
using System.Collections.Generic;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[ProtoContract(Name = "FallGuys_Player_LiveEventClaimResultDto_V1")]
public class LiveEventClaimResultDto
{
	private List<ItemAddedDto>? _itemsEarned;

	[Obsolete("Use LiveEvents instead.")]
	[ProtoMember(1)]
	public LiveEventDto? LiveEvent { get; set; }

	[ProtoMember(2)]
	public List<ItemAddedDto> ItemsEarned
	{
		get
		{
			return _itemsEarned ?? (_itemsEarned = new List<ItemAddedDto>());
		}
		set
		{
			_itemsEarned = value;
		}
	}

	[ProtoMember(3)]
	public LiveEventsDto? LiveEvents { get; set; }
}
