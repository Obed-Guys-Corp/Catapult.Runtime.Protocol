using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Entitlements;

[ProtoContract(Name = "FallGuys_Gateway_SyncEntitlementsForXboxCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class SyncEntitlementsForXboxCommand : ISyncEntitlementsCommand
{
    [ProtoMember(1)]
    public string XstsToken { get; set; } = null!;

    [ProtoMember(2)]
    public string CurrencyCode { get; set; } = null!;

    [ProtoMember(3)]
    public string StoreId { get; set; } = null!;

    [ProtoMember(4)]
    public string StorefrontId { get; set; } = null!;

    [ProtoMember(5)]
    public string SectionId { get; set; } = null!;

    [ProtoMember(6)]
    public string IapId { get; set; } = null!;

    [ProtoMember(7)]
    public string StoreSessionId { get; set; } = null!;

    [ProtoMember(8)]
    public SyncPointType SyncPoint { get; set; }

    [ProtoMember(9)]
    public string BundleId { get; set; } = null!;

    [ProtoMember(10)]
    public string CostDisplayLocal { get; set; } = null!;

    [ProtoMember(11)]
    public string CostUsd { get; set; } = null!;

    [ProtoMember(12)]
    public string CurrencyDisplayLocal { get; set; } = null!;

    [ProtoMember(13)]
    public string EntryPoint { get; set; } = null!;
}
