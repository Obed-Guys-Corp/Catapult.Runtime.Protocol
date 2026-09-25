using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony.PurchaseDtos;

[ProtoContract(Name = "FallGuys_Store_PurchaseDto_V1")]
public class PurchaseDto
{
    [ProtoMember(1)]
    public int? PurchaseQuantity { get; set; }
}
