using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "FallGuys_Store_SymphonyCostumeSetPaymentOption_V1")]
public class SymphonyCostumeSetPaymentOption : PaymentOption
{
    private List<string>? _itemsIds;

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

    [ProtoMember(6)]
    public List<string> ItemsIds { get; set; }

    [Obsolete("Use Line instead")]
    [ProtoMember(7)]
    public ItemPaymentLine[]? Lines { get; set; }

    [ProtoMember(8)]
    public ItemPaymentLine? Line { get; set; }
}
