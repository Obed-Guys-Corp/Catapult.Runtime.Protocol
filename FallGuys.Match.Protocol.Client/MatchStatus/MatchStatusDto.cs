using ProtoBuf;

namespace FallGuys.Match.Protocol.Client.MatchStatus;

[ProtoContract(Name = "FallGuys_Match_MatchStatusDto_V1")]
public class MatchStatusDto
{
	[ProtoMember(1)]
	public MatchStatus MatchStatus { get; set; }

	[ProtoMember(2)]
	public string? IpAddress { get; set; }

	[ProtoMember(3)]
	public int? Port { get; set; }

	[ProtoMember(4)]
	public string? GameServerToken { get; set; }

	[ProtoMember(5)]
	public int PlayerCount { get; set; }

	[ProtoMember(6)]
	public int BotCount { get; set; }
}
