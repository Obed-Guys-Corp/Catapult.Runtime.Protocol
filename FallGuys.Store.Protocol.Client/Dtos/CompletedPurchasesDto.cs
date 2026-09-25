using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_CompletedPurchasesDto_V1")]
public class CompletedPurchasesDto
{
    private List<CompletedPurchaseDto>? _purchaseDtos;

    [ProtoMember(1)]
    public List<CompletedPurchaseDto> PurchaseDtos { get; set; }
}
