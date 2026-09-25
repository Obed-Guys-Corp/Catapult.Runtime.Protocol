using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Metrics;

[ProtoContract(Name = "FallGuys_Player_MetricUpdateCollection_V1")]
public class MetricUpdateCollection
{
    [ProtoMember(1)]
    public List<MetricValueDto> MetricUpdateValues { get; set; } = null!;

    [ProtoMember(2)]
    public Dictionary<string, string> MetricUpdateDimensions { get; set; } = null!;
}
