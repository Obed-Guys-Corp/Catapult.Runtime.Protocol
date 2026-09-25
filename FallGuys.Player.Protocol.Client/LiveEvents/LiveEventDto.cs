using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[ProtoContract(Name = "FallGuys_Player_LiveEventDto_V1")]
public class LiveEventDto
{
    [ProtoMember(1)]
    public string? ContentId { get; set; }

    [ProtoMember(2)]
    public DateTime? StartsAt { get; set; }

    [ProtoMember(3)]
    public DateTime? EndsAt { get; set; }

    [ProtoMember(4)]
    public List<LiveEventChallengeDto> Goals { get; set; } = null!;

    [ProtoMember(5)]
    public List<LiveEventMilestoneDto> Milestones { get; set; } = null!;

    [ProtoMember(6)]
    public bool IsCompleted { get; set; }

    [ProtoMember(7)]
    public string? Id { get; set; }
}
