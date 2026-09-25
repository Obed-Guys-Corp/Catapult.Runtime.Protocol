using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.GetLobby;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Lobby_GetLobbyQuery_V1")]
public class GetLobbyQuery
{
	[ProtoMember(1)]
	public string LobbyId { get; set; }
}
