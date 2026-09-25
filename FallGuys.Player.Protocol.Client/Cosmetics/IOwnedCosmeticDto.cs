using Catapult.Modules.Items.Protocol.Dtos;
using System;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

public interface IOwnedCosmeticDto
{
    ItemDto? Item { get; set; }

    DateTime EarnedAt { set; }

    bool IsFavourite { get; set; }
}
