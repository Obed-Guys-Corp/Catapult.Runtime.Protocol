using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.PurchaseHistory.Dto;

[ProtoContract(Name = "FallGuys_PurchaseHistory_PurchasedBundleDto_V1")]
public class PurchasedBundleDto
{
    [ProtoIgnore]
    private List<PurchasedItemDto>? _purchasedItems;

    [ProtoMember(1)]
    public string? BundleId { get; set; }

    [ProtoMember(2)]
    public List<PurchasedItemDto> PurchasedItems { get; set; }

    [ProtoMember(3)]
    public DateTime PurchaseDate { get; set; }

    [ProtoMember(4)]
    public ItemPaymentDto? PurchasePayment { get; set; }

    [ProtoMember(5)]
    public PurchaseType? PurchaseType { get; set; }

    [ProtoMember(6)]
    public PurchasedBundleStatus PurchaseStatus { get; set; }

    [ProtoMember(7)]
    public string? StatusReason { get; set; }

    [ProtoMember(8)]
    public DateTime? ReturnedDate { get; set; }
}
