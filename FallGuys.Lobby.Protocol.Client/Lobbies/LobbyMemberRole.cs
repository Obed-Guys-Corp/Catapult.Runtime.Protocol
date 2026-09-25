using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Lobbies;

[ProtoContract(Name = "FallGuys_Lobby_LobbyMemberRole_V1")]
public enum LobbyMemberRole
{
	[ProtoEnum(Name = "unknown")]
	Unknown,
	[ProtoEnum(Name = "host")]
	Host,
	[ProtoEnum(Name = "participant")]
	Participant
}
