using FallGuys.Store.Protocol.Client.Dtos.Symphony.PurchaseDtos;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_SeasonPassOptionDto_V1")]
public class SeasonPassOptionDto
{
    [ProtoMember(1)]
    public PurchaseDto? PurchaseOption { get; set; }

    [ProtoMember(2)]
    public IReadOnlyCollection<SymphonyStoreBundleItemDto> Items { get; set; } = null!;

    [ProtoMember(3)]
    public int Index { get; set; }
}
