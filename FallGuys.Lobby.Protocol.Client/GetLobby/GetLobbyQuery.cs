using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.GetLobby;

[ProtoContract(Name = "FallGuys_Lobby_GetLobbyQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetLobbyQuery
{
    [ProtoMember(1)]
    public string LobbyId { get; set; } = null!;
}
