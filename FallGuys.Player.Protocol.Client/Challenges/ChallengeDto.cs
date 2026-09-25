using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.Challenges;

[ProtoContract(Name = "FallGuys_Player_ChallengeDto_V2")]
public class ChallengeDto
{
    [ProtoMember(1)]
    public string? Id { get; set; }

    [ProtoMember(2)]
    public string? ChallengeId { get; set; }

    [ProtoMember(3)]
    public int Progress { get; set; }

    [ProtoMember(4)]
    public int Goal { get; set; }

    [ProtoMember(5)]
    public string? RewardId { get; set; }

    [ProtoMember(6)]
    public bool IsAcknowledged { get; set; }

    [ProtoMember(7)]
    public DateTime? CompletedAt { get; set; }

    [Obsolete("No longer used")]
    [ProtoMember(8)]
    public string? Rarity { get; set; }

    [ProtoMember(9)]
    public bool Seen { get; set; }

    [Obsolete("No longer used")]
    [ProtoMember(10)]
    public string? DisplayName { get; set; }

    [Obsolete("No longer used")]
    [ProtoMember(11)]
    public string? EpisodeId { get; set; }

    [Obsolete("No longer used")]
    [ProtoMember(12)]
    public string? ReplacedChallengeId { get; set; }

    [ProtoMember(13)]
    public string? RewardContentId { get; set; }

    [ProtoMember(14)]
    public DateTime? LockedUntil { get; set; }
}
