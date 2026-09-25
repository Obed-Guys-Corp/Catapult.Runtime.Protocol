using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Metrics;

[ProtoContract(Name = "FallGuys_Player_MetricValueDto_V1")]
public class MetricValueDto
{
    private Dictionary<string, string>? _additionalDimensions;

    [ProtoMember(1)]
    public string? MetricId { get; set; }

    [ProtoMember(2)]
    public Dictionary<string, string> AdditionalDimensions { get; set; }

    [ProtoMember(3)]
    public int Value { get; set; }
}
