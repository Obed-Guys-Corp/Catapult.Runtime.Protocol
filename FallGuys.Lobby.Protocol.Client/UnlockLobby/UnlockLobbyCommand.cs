using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.UnlockLobby;

[ProtoContract(Name = "FallGuys_Lobby_UnlockLobbyCommand_V1")]
[Authorize(Roles = new string[] { "User" })]
public class UnlockLobbyCommand
{
	[ProtoMember(1)]
	public string LobbyId { get; set; }
}
