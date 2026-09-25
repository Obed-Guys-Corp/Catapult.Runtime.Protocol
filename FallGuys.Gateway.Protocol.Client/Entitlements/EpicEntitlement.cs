using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Entitlements;

[ProtoContract(Name = "FallGuys_Gateway_Entitlements_EpicEntitlement_V1")]
public class EpicEntitlement
{
    [ProtoMember(1)]
    public string EntitlementId { get; set; } = null!;

    [ProtoMember(2)]
    public string EntitlementName { get; set; } = null!;

    [ProtoMember(3)]
    public string CatalogItemId { get; set; } = null!;
}
