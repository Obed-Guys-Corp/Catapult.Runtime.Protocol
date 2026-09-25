using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_StoreDto_V2")]
public class StoreDto
{
    [ProtoMember(2)]
    public string? Id { get; set; }

    [ProtoMember(1)]
    public List<StoreSectionDto> Sections { get; set; } = null!;
}
