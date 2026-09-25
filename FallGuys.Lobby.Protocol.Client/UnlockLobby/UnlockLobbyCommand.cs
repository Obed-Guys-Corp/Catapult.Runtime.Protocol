using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.UnlockLobby;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Lobby_UnlockLobbyCommand_V1")]
public class UnlockLobbyCommand
{
    [ProtoMember(1)]
    public string LobbyId { get; set; }
}
