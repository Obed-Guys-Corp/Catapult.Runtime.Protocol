using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client;

[ProtoContract(Name = "FallGuys_Lobby_LobbyShowType_V1")]
public enum LobbyShowType
{
	[ProtoEnum(Name = "unknown")]
	Unknown,
	[ProtoEnum(Name = "cms")]
	Cms,
	[ProtoEnum(Name = "playlist")]
	Playlist
}
