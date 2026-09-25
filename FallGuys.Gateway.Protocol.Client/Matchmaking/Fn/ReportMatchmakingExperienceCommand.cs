using Catapult.Protocol;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking.Fn;

[ProtoContract(Name = "FallGuys_Matchmaking_ReportMatchmakingExperienceCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class ReportMatchmakingExperienceCommand
{
    [ProtoMember(1)]
    public string? MetaDataToken { get; set; }

    [ProtoMember(2)]
    public TimeSpan TimeToMatch { get; set; }

    [ProtoMember(3)]
    public MatchmakingResult MatchmakingResult { get; set; }

    [ProtoMember(4)]
    public TimeSpan? TimeToSession { get; set; }

    [ProtoMember(5)]
    public SessionStartResult? SessionStartResult { get; set; }

    [ProtoMember(6)]
    public List<EventDto> Events { get; set; } = null!;
}
