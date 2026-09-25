using Catapult.Protocol;
using FallGuys.Lobby.Protocol.Client.Lobbies;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.ChangeMemberStatus;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Lobby_ChangeMemberReadyStatusCommand_V1")]
public class ChangeMemberStatusCommand
{
    [ProtoMember(1)]
    public string? LobbyId { get; set; }

    [ProtoMember(2)]
    public LobbyMemberStatus NewStatus { get; set; }
}
