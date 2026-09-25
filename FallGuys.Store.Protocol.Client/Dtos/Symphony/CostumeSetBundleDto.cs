using FallGuys.Store.Protocol.Client.Dtos.Symphony.PurchaseDtos;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_CostumeSetBundleDto_V1")]
public class CostumeSetBundleDto : SymphonyStoreBundleDto
{
    [ProtoMember(1)]
    public int Discount { get; set; }

    [ProtoMember(2)]
    public PurchaseDto? PurchaseOption { get; set; }

    [ProtoMember(3)]
    public IEnumerable<SymphonyStoreBundleItemDto> Cosmetics { get; set; } = null!;
}
