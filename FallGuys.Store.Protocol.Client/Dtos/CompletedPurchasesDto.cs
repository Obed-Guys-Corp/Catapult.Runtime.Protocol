using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_CompletedPurchasesDto_V1")]
public class CompletedPurchasesDto
{
    [ProtoMember(1)]
    public List<CompletedPurchaseDto> PurchaseDtos { get; set; } = null!;
}
