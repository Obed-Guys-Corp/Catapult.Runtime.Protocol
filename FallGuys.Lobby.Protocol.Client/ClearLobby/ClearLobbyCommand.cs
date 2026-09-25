using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.ClearLobby;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Lobby_ClearLobbyCommand_V1")]
public class ClearLobbyCommand
{
	[ProtoMember(1)]
	public string LobbyId { get; set; }
}
