using System;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.CloseLobby;

[Obsolete("Use 'LeaveLobbyCommand' as Host, instead.")]
[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Lobby_CloseLobbyCommand_V1")]
public class CloseLobbyCommand
{
	[ProtoMember(1)]
	public string LobbyId { get; set; }
}
