using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_SymphonyCompletedPurchaseDto_V1")]
public class SymphonyCompletedPurchaseDto
{
    private List<ItemAddedDto>? _items;
    private List<SymphonyStoreBundleDto>? _purchasedBundles;

    [ProtoMember(1)]
    public List<ItemAddedDto> Items { get; set; }

    [ProtoMember(2)]
    public List<SymphonyStoreBundleDto> PurchasedBundles { get; set; }
}
