using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Reputation;

[ProtoContract(Name = "FallGuys_Player_InfractionsSummaryDto_V1")]
public class InfractionsSummaryDto
{
	[ProtoMember(1)]
	public int Terminal { get; set; }

	[ProtoMember(2)]
	public int Major { get; set; }

	[ProtoMember(3)]
	public int Mid { get; set; }

	[ProtoMember(4)]
	public int Minor { get; set; }
}
