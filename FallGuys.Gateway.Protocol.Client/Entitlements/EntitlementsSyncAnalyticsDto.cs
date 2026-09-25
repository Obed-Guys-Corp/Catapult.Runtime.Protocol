using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Entitlements;

[ProtoContract(Name = "FallGuys_Entitlements_EntitlementsSyncAnalyticsDto_V1")]
public class EntitlementsSyncAnalyticsDto
{
    [ProtoMember(1)]
    public string? CostUsd { get; set; }

    [ProtoMember(2)]
    public string? CostDisplayLocal { get; set; }

    [ProtoMember(3)]
    public string? CurrencyCode { get; set; }

    [ProtoMember(4)]
    public string? CurrencyDisplayLocal { get; set; }

    [ProtoMember(5)]
    public string? StoreId { get; set; }

    [ProtoMember(6)]
    public string? StorefrontId { get; set; }

    [ProtoMember(7)]
    public string? SectionId { get; set; }

    [ProtoMember(8)]
    public string? IapId { get; set; }

    [ProtoMember(9)]
    public string? StoreSessionId { get; set; }

    [ProtoMember(10)]
    public string? EntryPoint { get; set; }

    [ProtoMember(11)]
    public SyncPointType SyncPoint { get; set; }
}
