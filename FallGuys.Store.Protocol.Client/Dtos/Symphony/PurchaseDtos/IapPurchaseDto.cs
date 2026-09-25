using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony.PurchaseDtos;

[ProtoContract(Name = "FallGuys_Store_IapPurchaseDto_V1")]
public class IapPurchaseDto : PurchaseDto
{
    [ProtoMember(1)]
    public string? IapId { get; set; }
}
