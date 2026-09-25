using ProtoBuf;
using System.Collections.Generic;

namespace Catapult.Modules.Items.Protocol.Dtos;

[ProtoContract(Name = "Catapult_Items_ItemRemoveResultDto_V1")]
public class ItemRemovedDto
{
    [ProtoMember(1)]
    public string? Id { get; set; }

    [ProtoMember(2)]
    public string? ContentId { get; set; }

    [ProtoMember(3)]
    public string? ContentType { get; set; }

    [ProtoMember(4)]
    public List<ItemChangedDto> Changes { get; set; } = null!;
}
