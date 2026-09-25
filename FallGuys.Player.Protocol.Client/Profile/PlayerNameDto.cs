using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Profile;

[ProtoContract(Name = "FallGuys_Profile_PlayerNameDto_V1")]
public class PlayerNameDto
{
	[ProtoMember(1)]
	public int FirstSegmentIndex { get; set; }

	[ProtoMember(2)]
	public int SecondSegmentIndex { get; set; }

	[ProtoMember(3)]
	public int ThirdSegmentIndex { get; set; }

	[ProtoMember(4)]
	public PlayerNameLanguage Language { get; set; }

	[ProtoMember(5)]
	public string PlayerName { get; set; }
}
