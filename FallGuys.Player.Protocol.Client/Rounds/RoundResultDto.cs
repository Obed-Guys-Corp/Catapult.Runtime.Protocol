using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Rounds;

[ProtoContract(Name = "FallGuys_Player_Rounds_RoundResult_V1")]
public class RoundResultDto
{
    [ProtoMember(1)]
    public List<RoundRewardDto> Rewards { get; set; } = null!;

    [ProtoMember(2)]
    public RoundCorrelationDto? SessionCorrelation { get; set; }

    [ProtoMember(3)]
    public PerformanceDto? Performance { get; set; }

    [ProtoMember(4)]
    public LevelDto? Level { get; set; }

    [ProtoMember(5)]
    public DateTime ProcessedAtUtc { get; set; }

    [ProtoMember(6)]
    public string? RoundId { get; set; }
}
