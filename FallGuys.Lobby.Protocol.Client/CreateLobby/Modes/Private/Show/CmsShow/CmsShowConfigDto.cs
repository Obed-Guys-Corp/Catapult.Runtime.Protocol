using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.CreateLobby.Modes.Private.Show.CmsShow;

[ProtoContract(Name = "FallGuys_Lobby_Client_Create_CmsShowConfigDto_V1")]
public class CmsShowConfigDto
{
	[ProtoMember(1)]
	public string? ShowContentId { get; set; }
}
