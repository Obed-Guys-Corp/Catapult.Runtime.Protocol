using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[ProtoContract(Name = "FallGuys_FaceplateDto_V1")]
public class FaceplateDto : IOwnedCosmeticDto
{
    [ProtoMember(1)]
    public ItemDto Item { get; set; } = null!;

    [ProtoMember(2)]
    public DateTime EarnedAt { get; set; }

    [ProtoMember(3)]
    public bool IsFavourite { get; set; }
}
