using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Private.Show.Playlist;

[ProtoContract(Name = "FallGuys_Lobby_Client_Read_PlaylistShowConfigDto_V1")]
public class PlaylistShowConfigDto
{
	[ProtoMember(1)]
	public RawJsonDto? PlaylistJson { get; set; }
}
