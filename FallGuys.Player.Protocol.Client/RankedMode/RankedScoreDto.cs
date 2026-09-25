using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.RankedMode;

[ProtoContract(Name = "FallGuys_Player_RankedMode_RankedScoreDto_V1")]
public class RankedScoreDto
{
    [ProtoMember(1)]
    public string? Chainkey { get; set; }

    [ProtoMember(2)]
    public int HighScore { get; set; }

    [ProtoMember(3)]
    public int CurrentScore { get; set; }

    [ProtoMember(4)]
    public DateTime StartedAt { get; set; }

    [ProtoMember(5)]
    public DateTime? RewardsClaimedAt { get; set; }

    [ProtoMember(6)]
    public bool IsClaimable { get; set; }
}
