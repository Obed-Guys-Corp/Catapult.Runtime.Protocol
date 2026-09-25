using System;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[ProtoContract(Name = "FallGuys_Player_MonolithicCostumeDto_V1")]
public class MonolithicCostumeDto : IOwnedCosmeticDto
{
	[ProtoMember(1)]
	public ItemDto Item { get; set; }

	[ProtoMember(2)]
	public DateTime EarnedAt { get; set; }

	[ProtoMember(3)]
	public bool IsFavourite { get; set; }
}
