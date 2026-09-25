using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.PurchaseHistory.Dto;

[ProtoContract(Name = "FallGuys_PurchaseHistory_PurchaseHistoryResponseDto_V1")]
public class PurchaseHistoryResponseDto
{
    [ProtoIgnore]
    private List<PurchasedBundleDto>? _purchasedBundles;

    [ProtoMember(1)]
    public List<PurchasedBundleDto> PurchasedBundles { get; set; }

    [ProtoMember(2)]
    public ReturnTicketDto? ReturnTicket { get; set; }
}
