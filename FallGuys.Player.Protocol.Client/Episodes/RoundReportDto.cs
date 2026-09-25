using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_RoundReportDto_V1")]
public class RoundReportDto
{
	[ProtoMember(1)]
	public int RoundIndex { get; set; }

	[ProtoMember(2)]
	public string BadgeId { get; set; }

	[ProtoMember(3)]
	public string LevelId { get; set; }

	[ProtoMember(4)]
	public int? BonusTierIndex { get; set; }
}
