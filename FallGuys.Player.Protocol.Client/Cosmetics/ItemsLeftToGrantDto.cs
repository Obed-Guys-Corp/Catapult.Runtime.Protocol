using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[ProtoContract(Name = "FallGuys_Player_ItemsLeftToGrantDto_V1")]
public class ItemsLeftToGrantDto
{
    [ProtoMember(1)]
    public int ItemsLeftToGrant { get; set; }

    [ProtoMember(2)]
    public List<ItemAddedDto> ItemsGranted { get; set; }
}
