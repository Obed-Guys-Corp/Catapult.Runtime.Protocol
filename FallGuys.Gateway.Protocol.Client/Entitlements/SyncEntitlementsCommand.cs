using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Gateway.Protocol.Client.Entitlements;

[ProtoContract(Name = "FallGuys_Entitlements_SyncEntitlementsCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class SyncEntitlementsCommand
{
    [ProtoMember(1)]
    public string? ProviderId { get; set; }

    [ProtoMember(2)]
    public Dictionary<string, string> Data { get; set; } = null!;

    [ProtoMember(3)]
    public EntitlementsSyncAnalyticsDto? Analytics { get; set; }
}
