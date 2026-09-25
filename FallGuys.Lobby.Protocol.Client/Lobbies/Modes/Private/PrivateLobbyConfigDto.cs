using FallGuys.Lobby.Protocol.Client.CreateLobby.Modes.Private.Show.CmsShow;
using FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Private.Show.Playlist;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Private;

[ProtoContract(Name = "FallGuys_Lobby_Client_Read_PrivateLobbyConfigDto_V1")]
public class PrivateLobbyConfigDto
{
	[ProtoMember(1)]
	public LobbyShowType ShowType { get; set; }

	[ProtoMember(2)]
	public CmsShowConfigDto? CmsShowConfig { get; set; }

	[ProtoMember(3)]
	public PlaylistShowConfigDto? PlaylistShowConfig { get; set; }
}
