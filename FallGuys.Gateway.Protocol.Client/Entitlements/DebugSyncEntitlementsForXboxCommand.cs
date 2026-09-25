using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;
using System;

namespace FallGuys.Gateway.Protocol.Client.Entitlements;

[DebugMessage]
[ProtoContract(Name = "FallGuys_Gateway_DebugSyncEntitlementsForXboxCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class DebugSyncEntitlementsForXboxCommand : ISyncEntitlementsCommand
{
    [ProtoMember(1)]
    public string XstsToken { get; set; } = null!;

    [ProtoMember(2)]
    public string Sandbox { get; set; } = null!;

    [ProtoMember(3)]
    public string CurrencyCode { get; set; } = null!;

    [ProtoMember(4)]
    public string StoreId { get; set; } = null!;

    [ProtoMember(5)]
    public string StorefrontId { get; set; } = null!;

    [ProtoMember(6)]
    public string SectionId { get; set; } = null!;

    [ProtoMember(7)]
    public string IapId { get; set; } = null!;

    [ProtoMember(8)]
    public string StoreSessionId { get; set; } = null!;

    [ProtoMember(9)]
    public SyncPointType SyncPoint { get; set; }

    [ProtoMember(10)]
    [Obsolete("Not used by upstream xbox api call")]
    public string BundleId { get; set; } = null!;

    [ProtoMember(11)]
    public string CostDisplayLocal { get; set; } = null!;

    [ProtoMember(12)]
    public string CostUsd { get; set; } = null!;

    [ProtoMember(13)]
    public string CurrencyDisplayLocal { get; set; } = null!;

    [ProtoMember(14)]
    public string EntryPoint { get; set; } = null!;
}
