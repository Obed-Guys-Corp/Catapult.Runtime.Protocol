using Catapult.Protocol;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking;

[Obsolete("Use fn matchmaker")]
[ProtoContract(Name = "FallGuys_Gateway_JoinMatchmakingCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class JoinMatchmakingCommand
{
    [ProtoMember(1)]
    public List<string> CompanionIdentities { get; set; } = null!;

    [ProtoMember(2)]
    public QosResultsDto QosResults { get; set; } = null!;

    [ProtoMember(3)]
    public string EntryCode { get; set; } = null!;

    [ProtoMember(4)]
    public List<string> ShowIds { get; set; } = null!;

    [ProtoMember(5)]
    public string RegionIdOverride { get; set; } = null!;

    [ProtoMember(6)]
    public bool CrossPlayEnabled { get; set; }

    [ProtoMember(7)]
    public string Profile { get; set; } = null!;
}
