using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "FallGuys_Store_PurchaseIapRegionPrice_V1")]
public class PurchaseIapRegionPrice
{
    [ProtoMember(1)]
    public string? CurrencyIsoCode { get; set; }

    [ProtoMember(2)]
    public float BundlePrice { get; set; }
}
