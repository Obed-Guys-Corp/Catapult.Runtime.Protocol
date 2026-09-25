using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_CompletedPurchaseDto_V1")]
public class CompletedPurchaseDto
{
    private List<ItemAddedDto>? _items;
    private List<StoreBundleDto>? _purchasedBundles;

    [ProtoMember(1)]
    public List<ItemAddedDto> Items { get; set; }

    [ProtoMember(2)]
    public List<StoreBundleDto> PurchasedBundles { get; set; }
}
