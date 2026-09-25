using Catapult.Protocol;
using FallGuys.Lobby.Protocol.Client.CreateLobby.Modes.Debug;
using FallGuys.Lobby.Protocol.Client.CreateLobby.Modes.Private;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.SelectShows;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Lobby_Client_SelectNextShowCommand_V1")]
public class SelectNextShowCommand
{
    private PrivateLobbyConfigDto? _privateLobbyConfig;

    [ProtoMember(1)]
    public string? LobbyId { get; set; }

    [ProtoMember(4)]
    public LobbyType LobbyType { get; set; }

    [ProtoMember(2)]
    public string? ShowId { get; set; }

    [ProtoMember(3)]
    public DebugLobbyConfigDto? DebugLobbyConfig { get; set; }

    [ProtoMember(5)]
    public PrivateLobbyConfigDto? PrivateLobbyConfig { get; set; }
}
