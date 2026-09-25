using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.Receipts;

[ProtoContract(Name = "FallGuys_Player_SteamReceiptDto_V1")]
public class SteamReceiptDto
{
    [ProtoMember(8)]
    public string Id { get; set; }

    [ProtoMember(1)]
    public ulong ItemId { get; set; }

    [ProtoMember(2)]
    public ulong OrderId { get; set; }

    [ProtoMember(3)]
    public ulong SteamId { get; set; }

    [ProtoMember(4)]
    public DateTime? PurchaseDate { get; set; }

    [ProtoMember(5)]
    public ulong TransactionId { get; set; }

    [ProtoMember(6)]
    public bool IsRefunded { get; set; }

    [ProtoMember(7)]
    public DateTime ProcessedAt { get; set; }
}
