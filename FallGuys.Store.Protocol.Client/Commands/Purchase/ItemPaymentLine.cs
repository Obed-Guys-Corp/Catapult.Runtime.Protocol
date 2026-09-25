using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "Catapult_Store_PurchaseBundleCommand_ItemPaymentLine_V1")]
public class ItemPaymentLine
{
    [ProtoMember(1)]
    public string? ItemId { get; set; }

    [ProtoMember(2)]
    public int Quantity { get; set; }
}
