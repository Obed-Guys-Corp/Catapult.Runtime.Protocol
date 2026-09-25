using ProtoBuf;
using System;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "FallGuys_Store_SymphonyItemPaymentOption_V1")]
public class SymphonyItemPaymentOption : PaymentOption
{
    [ProtoMember(1)]
    public string? StoreId { get; set; }

    [ProtoMember(2)]
    public string? SectionId { get; set; }

    [ProtoMember(3)]
    public string? StorefrontId { get; set; }

    [ProtoMember(4)]
    public string? BundleSlotId { get; set; }

    [ProtoMember(5)]
    public string? BundleId { get; set; }

    [Obsolete("Use Line instead")]
    [ProtoMember(6)]
    public ItemPaymentLine[]? Lines { get; set; }

    [ProtoMember(7)]
    public ItemPaymentLine? Line { get; set; }
}
