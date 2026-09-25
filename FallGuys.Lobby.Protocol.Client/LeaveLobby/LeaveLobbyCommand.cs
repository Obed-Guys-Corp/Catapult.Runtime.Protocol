using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.LeaveLobby;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Lobby_LeaveLobbyCommand_V1")]
public class LeaveLobbyCommand
{
    [ProtoMember(1)]
    public string LobbyId { get; set; } = null!;
}
