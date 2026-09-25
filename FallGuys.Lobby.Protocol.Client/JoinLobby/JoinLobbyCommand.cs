using System;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.JoinLobby;

[ProtoContract(Name = "FallGuys_Lobby_JoinLobbyCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class JoinLobbyCommand
{
	[ProtoMember(1)]
	[Obsolete("Use 'EntryCode' instead")]
	public string LobbyId { get; set; }

	[ProtoMember(2)]
	public string EntryCode { get; set; }

	[ProtoMember(3)]
	public bool CrossPlayEnabled { get; set; }
}
