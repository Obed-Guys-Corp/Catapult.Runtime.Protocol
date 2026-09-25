using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Matchmaking;

[ProtoContract(Name = "Fg_Lobby_UnlockMatchmakingCommand")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class UnlockMatchmakingCommand
{
    [ProtoMember(1)]
    public string? LobbyId { get; set; }

    [ProtoMember(2)]
    public string? PoolId { get; set; }
}
