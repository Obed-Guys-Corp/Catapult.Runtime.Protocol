using Catapult.Protocol;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Metrics;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_LogMetricUpdateCommand_V1")]
public class LogMetricUpdateCommand
{
    private List<MetricUpdateCollection>? _metricUpdateCollections;
    private Dictionary<string, MetricUpdateDto>? _metricUpdates;
    private List<MetricContextType>? _contextTypes;

    [Obsolete("Use MetricUpdateCollections instead.")]
    [ProtoMember(1)]
    public Dictionary<string, MetricUpdateDto> MetricUpdates { get; set; }

    [ProtoMember(2)]
    public List<MetricContextType> ContextTypes { get; set; }

    [ProtoMember(3)]
    public List<MetricUpdateCollection> MetricUpdateCollections { get; set; }
}
