using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Common;

[ProtoContract(Name = "FallGuys_Lobby_LobbyMemberNameDto_V1")]
public class LobbyMemberNameDto
{
	[ProtoMember(1)]
	public int FirstSegmentIndex { get; set; }

	[ProtoMember(2)]
	public int SecondSegmentIndex { get; set; }

	[ProtoMember(3)]
	public int ThirdSegmentIndex { get; set; }

	[ProtoMember(4)]
	public int LanguageIndex { get; set; }

	[ProtoMember(5)]
	public string? PlayerName { get; set; }
}
