using System;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client;

[ProtoContract(Name = "FallGuys_Lobby_LobbyType_V1")]
public enum LobbyType
{
	[ProtoEnum(Name = "unknown")]
	Unknown,
	[ProtoEnum(Name = "private")]
	Private,
	[ProtoEnum(Name = "party")]
	[Obsolete("We don't support party lobbies anymore")]
	Party,
	[ProtoEnum(Name = "debug")]
	Debug,
	[ProtoEnum(Name = "preview")]
	Preview
}
