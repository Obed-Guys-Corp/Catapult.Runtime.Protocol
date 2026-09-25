using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony.PurchaseDtos;

[ProtoContract(Name = "FallGuys_Store_ItemPurchaseDto_V1")]
public class ItemPurchaseDto : PurchaseDto
{
    [ProtoMember(1)]
    public ItemPaymentLineDto? Item { get; set; }
}
