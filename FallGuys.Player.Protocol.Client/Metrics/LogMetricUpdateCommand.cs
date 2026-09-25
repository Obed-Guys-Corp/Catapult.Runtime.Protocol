using Catapult.Protocol;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Metrics;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_LogMetricUpdateCommand_V1")]
public class LogMetricUpdateCommand
{
    [Obsolete("Use MetricUpdateCollections instead.")]
    [ProtoMember(1)]
    public Dictionary<string, MetricUpdateDto> MetricUpdates { get; set; } = null!;

    [ProtoMember(2)]
    public List<MetricContextType> ContextTypes { get; set; } = null!;

    [ProtoMember(3)]
    public List<MetricUpdateCollection> MetricUpdateCollections { get; set; } = null!;
}
