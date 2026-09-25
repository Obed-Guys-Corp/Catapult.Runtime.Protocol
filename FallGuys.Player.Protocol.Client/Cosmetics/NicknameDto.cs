using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[ProtoContract(Name = "FallGuys_Player_NicknameDto_V1")]
public class NicknameDto : IOwnedCosmeticDto
{
    [ProtoMember(1)]
    public ItemDto? Item { get; set; }

    [ProtoMember(2)]
    public DateTime EarnedAt { get; set; }

    [ProtoMember(3)]
    public bool IsFavourite { get; set; }
}
