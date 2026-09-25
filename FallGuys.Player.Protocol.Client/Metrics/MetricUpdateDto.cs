using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Metrics;

[ProtoContract(Name = "FallGuys_Player_MetricUpdateDto_V1")]
public class MetricUpdateDto
{
	private Dictionary<string, string>? _dimensions;

	[ProtoMember(1)]
	public string? MetricId { get; set; }

	[ProtoMember(2)]
	public Dictionary<string, string> Dimensions
	{
		get
		{
			return _dimensions ?? (_dimensions = new Dictionary<string, string>());
		}
		set
		{
			_dimensions = value;
		}
	}

	[ProtoMember(3)]
	public int Value { get; set; }
}
