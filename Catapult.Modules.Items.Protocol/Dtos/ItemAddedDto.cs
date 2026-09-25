using ProtoBuf;
using System.Collections.Generic;

namespace Catapult.Modules.Items.Protocol.Dtos;

[ProtoContract(Name = "Catapult_Items_ItemAddResultDto_V1")]
public class ItemAddedDto
{
    [ProtoMember(1)]
    public string? ContentId { get; set; }

    [ProtoMember(2)]
    public string? ContentType { get; set; }

    [ProtoMember(3)]
    public List<ItemChangedDto> Changes { get; set; } = null!;
}
