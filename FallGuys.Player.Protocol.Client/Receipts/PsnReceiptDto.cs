using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.Receipts;

[ProtoContract(Name = "FallGuys_Player_PsnReceiptDto_V1")]
public class PsnReceiptDto
{
    [ProtoMember(8)]
    public string Id { get; set; } = null!;

    [ProtoMember(1)]
    public string ItemId { get; set; } = null!;

    [ProtoMember(2)]
    public ulong UseCount { get; set; }

    [ProtoMember(3)]
    public string AccountId { get; set; } = null!;

    [ProtoMember(4)]
    public bool IsNonConsumable { get; set; }

    [ProtoMember(5)]
    public DateTime? PurchaseDate { get; set; }

    [ProtoMember(6)]
    public bool IsRefunded { get; set; }

    [ProtoMember(7)]
    public DateTime ProcessedAt { get; set; }
}
