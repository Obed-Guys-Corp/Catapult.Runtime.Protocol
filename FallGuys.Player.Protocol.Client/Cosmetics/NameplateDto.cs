using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[ProtoContract(Name = "FallGuys_Player_NameplateDto_V1")]
public class NameplateDto : IOwnedCosmeticDto
{
    [ProtoMember(1)]
    public ItemDto Item { get; set; } = null!;

    [ProtoMember(2)]
    public DateTime EarnedAt { get; set; }

    [ProtoMember(3)]
    public int TrackedValue { get; set; }

    [ProtoMember(4)]
    public bool IsFavourite { get; set; }
}
