using System.Collections.Generic;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[ProtoContract(Name = "FallGuys_Player_ItemsLeftToGrantDto_V1")]
public class ItemsLeftToGrantDto
{
	[ProtoMember(1)]
	public int ItemsLeftToGrant { get; set; }

	[ProtoMember(2)]
	public List<ItemAddedDto> ItemsGranted { get; set; }
}
