using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Metrics;

[ProtoContract(Name = "FallGuys_Player_PlayerMetricsDto_V2")]
public class PlayerMetricsDto
{
    [ProtoMember(1)]
    public Dictionary<string, PlayerMetricDto> Metrics { get; set; } = null!;
}
