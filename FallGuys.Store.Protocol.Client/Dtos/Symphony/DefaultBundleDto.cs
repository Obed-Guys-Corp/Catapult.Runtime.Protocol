using FallGuys.Store.Protocol.Client.Dtos.Symphony.PurchaseDtos;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_DefaultBundleDto_V1")]
public class DefaultBundleDto : SymphonyStoreBundleDto
{
    private IEnumerable<SymphonyStoreBundleItemDto>? _cosmetics;
    private IEnumerable<SymphonyStoreBundleItemDto>? _extra;

    [ProtoMember(1)]
    public PurchaseDto? PurchaseOption { get; set; }

    [ProtoMember(2)]
    public IEnumerable<SymphonyStoreBundleItemDto> Cosmetics { get; set; }

    [ProtoMember(3)]
    public IEnumerable<SymphonyStoreBundleItemDto> Extra { get; set; }

    [ProtoMember(4)]
    public IapRegionPriceDto? IapRegionPrice { get; set; }
}
