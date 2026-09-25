using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_StoreBundleRewardDto_V1")]
public class SymphonyStoreBundleRewardDto
{
    private List<SymphonyStoreBundleItemDto>? _items;

    [ProtoMember(1)]
    public List<SymphonyStoreBundleItemDto> Items { get; set; }
}
