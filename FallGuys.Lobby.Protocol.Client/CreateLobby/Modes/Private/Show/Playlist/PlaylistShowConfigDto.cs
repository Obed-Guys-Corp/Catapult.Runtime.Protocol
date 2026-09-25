using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.CreateLobby.Modes.Private.Show.Playlist;

[ProtoContract(Name = "FallGuys_Lobby_Client_Create_PlaylistShowConfigDto_V1")]
public class PlaylistShowConfigDto
{
	[ProtoMember(1)]
	public string? PlaylistToken { get; set; }
}
