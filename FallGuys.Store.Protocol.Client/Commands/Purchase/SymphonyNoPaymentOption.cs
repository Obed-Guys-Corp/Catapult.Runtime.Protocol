using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "FallGuys_Store_SymphonyNoPaymentOption_V1")]
public class SymphonyNoPaymentOption : PaymentOption
{
    [ProtoMember(1)]
    public string? StoreId { get; set; }

    [ProtoMember(2)]
    public string? StorefrontId { get; set; }

    [ProtoMember(3)]
    public string? SectionId { get; set; }

    [ProtoMember(4)]
    public string? BundleSlotId { get; set; }

    [ProtoMember(5)]
    public string? BundleId { get; set; }
}
