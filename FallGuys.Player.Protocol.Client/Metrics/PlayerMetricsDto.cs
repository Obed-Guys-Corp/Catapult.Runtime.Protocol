using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Metrics;

[ProtoContract(Name = "FallGuys_Player_PlayerMetricsDto_V2")]
public class PlayerMetricsDto
{
	private Dictionary<string, PlayerMetricDto>? _metrics;

	[ProtoMember(1)]
	public Dictionary<string, PlayerMetricDto> Metrics
	{
		get
		{
			return _metrics ?? (_metrics = new Dictionary<string, PlayerMetricDto>());
		}
		set
		{
			_metrics = value;
		}
	}
}
