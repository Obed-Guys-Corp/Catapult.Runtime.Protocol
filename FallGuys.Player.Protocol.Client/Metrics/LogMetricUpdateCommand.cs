using System;
using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Metrics;

[ProtoContract(Name = "FallGuys_Player_LogMetricUpdateCommand_V1")]
[Authorize(Roles = new string[] { "User" })]
public class LogMetricUpdateCommand
{
	private List<MetricUpdateCollection>? _metricUpdateCollections;

	private Dictionary<string, MetricUpdateDto>? _metricUpdates;

	private List<MetricContextType>? _contextTypes;

	[ProtoMember(1)]
	[Obsolete("Use MetricUpdateCollections instead.")]
	public Dictionary<string, MetricUpdateDto> MetricUpdates
	{
		get
		{
			return _metricUpdates ?? (_metricUpdates = new Dictionary<string, MetricUpdateDto>());
		}
		set
		{
			_metricUpdates = value;
		}
	}

	[ProtoMember(2)]
	public List<MetricContextType> ContextTypes
	{
		get
		{
			return _contextTypes ?? (_contextTypes = new List<MetricContextType>());
		}
		set
		{
			_contextTypes = value;
		}
	}

	[ProtoMember(3)]
	public List<MetricUpdateCollection> MetricUpdateCollections
	{
		get
		{
			return _metricUpdateCollections ?? (_metricUpdateCollections = new List<MetricUpdateCollection>());
		}
		set
		{
			_metricUpdateCollections = value;
		}
	}
}
