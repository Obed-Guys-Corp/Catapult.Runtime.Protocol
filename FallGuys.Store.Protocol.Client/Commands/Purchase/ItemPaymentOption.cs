using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "Catapult_Store_PurchaseBundleCommand_ItemPaymentOption_V2")]
public class ItemPaymentOption : PaymentOption
{
    [ProtoMember(1)]
    public string? StoreId { get; set; }

    [ProtoMember(2)]
    public string? StoreSectionId { get; set; }

    [ProtoMember(3)]
    public string? StoreBundleId { get; set; }

    [ProtoMember(4)]
    public ItemPaymentLine[] Lines { get; set; } = null!;
}
