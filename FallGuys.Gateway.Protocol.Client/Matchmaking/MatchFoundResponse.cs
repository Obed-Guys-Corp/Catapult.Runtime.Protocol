using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking;

[ProtoContract(Name = "FallGuys_Gateway_MatchFoundResponse_V1")]
public class MatchFoundResponse
{
    [Obsolete("Please use 'ServerIp' and 'ServerPort'.")]
    [ProtoMember(1)]
    public string ServerAddress { get; set; } = null!;

    [ProtoMember(3)]
    public string ServerIp { get; set; } = null!;

    [ProtoMember(4)]
    public string ServerPort { get; set; } = null!;

    [ProtoMember(5)]
    public string PartyLeaderEntryToken { get; set; } = null!;

    [ProtoMember(2)]
    public Dictionary<string, string> CompanionEntryTokensByIdentity { get; set; } = null!;
}
