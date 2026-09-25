using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Refunds.Steam;

[ProtoContract(Name = "Catapult_Store_SteamStoreItem_V1")]
public class StoreItem
{
    [ProtoMember(1)]
    public ulong ItemId { get; set; }

    [ProtoMember(2)]
    public ulong Quantity { get; set; }

    [ProtoMember(3)]
    public ulong Amount { get; set; }

    [ProtoMember(4)]
    public string? ItemStatus { get; set; }

    [ProtoMember(5)]
    public ulong Vat { get; set; }

    [ProtoMember(6)]
    public string? Description { get; set; }
}
