using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[ProtoContract(Name = "FallGuys_SocialWheelDto_V1")]
public class SocialWheelDto
{
    private Dictionary<int, ItemDto>? _itemsBySlot;

    [ProtoMember(1)]
    public string? Id { get; set; }

    [ProtoMember(2)]
    public Dictionary<int, ItemDto> ItemsBySlot { get; set; }
}
