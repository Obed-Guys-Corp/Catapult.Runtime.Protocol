using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_SymphonyCompletedPurchaseDto_V1")]
public class SymphonyCompletedPurchaseDto
{
    [ProtoMember(1)]
    public List<ItemAddedDto> Items { get; set; } = null!;

    [ProtoMember(2)]
    public List<SymphonyStoreBundleDto> PurchasedBundles { get; set; } = null!;
}
