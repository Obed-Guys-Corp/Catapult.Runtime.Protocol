using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Metrics;

[ProtoContract(Name = "FallGuys_Player_MetricUpdateCollection_V1")]
public class MetricUpdateCollection
{
	private List<MetricValueDto>? _metricUpdateValues;

	private Dictionary<string, string>? _metricUpdateDimensions;

	[ProtoMember(1)]
	public List<MetricValueDto> MetricUpdateValues
	{
		get
		{
			return _metricUpdateValues ?? (_metricUpdateValues = new List<MetricValueDto>());
		}
		set
		{
			_metricUpdateValues = value;
		}
	}

	[ProtoMember(2)]
	public Dictionary<string, string> MetricUpdateDimensions
	{
		get
		{
			return _metricUpdateDimensions ?? (_metricUpdateDimensions = new Dictionary<string, string>());
		}
		set
		{
			_metricUpdateDimensions = value;
		}
	}
}
