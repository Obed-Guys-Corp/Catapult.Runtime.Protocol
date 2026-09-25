using ProtoBuf;
using System;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking;

[ProtoContract(Name = "FallGuys_Gateway_Matchmaking_MatchmakingSessionDto_V1")]
public class MatchmakingSessionDto
{
    [ProtoMember(1)]
    public DateTime? StartsAt { get; set; }

    [ProtoMember(2)]
    public DateTime? EndsAt { get; set; }
}
