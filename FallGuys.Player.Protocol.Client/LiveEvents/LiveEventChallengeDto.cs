using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[ProtoContract(Name = "FallGuys_Player_LiveEventChallengeDto_V1")]
public class LiveEventChallengeDto
{
    [ProtoMember(1)]
    public string? Id { get; set; }

    [ProtoMember(2)]
    public int? Progress { get; set; }

    [ProtoMember(3)]
    public bool IsUnlocked { get; set; }

    [ProtoMember(4)]
    public string[] UnlockConditionGoalIds { get; set; } = null!;

    [ProtoMember(5)]
    public DateTime? LockedUntil { get; set; }
}
