using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_StoreSectionDto_V1")]
public class StoreSectionDto
{
    private List<StoreBundleDto>? _bundles;

    [ProtoMember(1)]
    public string? Id { get; set; }

    [ProtoMember(2)]
    public string? Name { get; set; }

    [ProtoMember(3)]
    public int Priority { get; set; }

    [ProtoMember(4)]
    public List<StoreBundleDto> Bundles { get; set; }
}
