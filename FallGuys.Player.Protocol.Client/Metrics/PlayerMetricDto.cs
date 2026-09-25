using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Metrics;

[ProtoContract(Name = "FallGuys_Player_PlayerMetricDto_V1")]
public class PlayerMetricDto
{
	[ProtoMember(1)]
	public int Min { get; set; }

	[ProtoMember(2)]
	public int Max { get; set; }

	[ProtoMember(3)]
	public int Last { get; set; }

	[ProtoMember(4)]
	public int Aggregate { get; set; }
}
