using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Matchmaking;

[ProtoContract(Name = "FallGuys_Lobby_CancelMatchmakingCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class CancelMatchmakingCommand
{
    [ProtoMember(1)]
    public string LobbyId { get; set; } = null!;
}
