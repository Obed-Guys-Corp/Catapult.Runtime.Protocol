using System;
using Catapult.Modules.Items.Protocol.Dtos;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

public interface IOwnedCosmeticDto
{
	ItemDto Item { get; set; }

	DateTime EarnedAt { set; }

	bool IsFavourite { get; set; }
}
