using Catapult.Protocol;
using FallGuys.Lobby.Protocol.Client.CreateLobby.Modes.Debug;
using FallGuys.Lobby.Protocol.Client.CreateLobby.Modes.Preview;
using FallGuys.Lobby.Protocol.Client.CreateLobby.Modes.Private;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Lobby.Protocol.Client.CreateLobby;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Lobby_CreateLobbyCommand_V1")]
public class CreateLobbyCommand
{
    [ProtoMember(1)]
    public LobbyType LobbyType { get; set; }

    [ProtoMember(2)]
    public string? ShowId { get; set; }

    [ProtoMember(3)]
    public List<QosResultDto>? QosResults { get; set; }

    [ProtoMember(4)]
    public string? RegionIdOverride { get; set; }

    [ProtoMember(5)]
    public bool CrossPlayEnabled { get; set; }

    [ProtoMember(6)]
    public string? ProfileId { get; set; }

    [ProtoMember(7)]
    public DebugLobbyConfigDto? DebugLobbyConfig { get; set; }

    [ProtoMember(8)]
    public PreviewLobbyConfigDto? PreviewLobbyConfig { get; set; }

    [ProtoMember(9)]
    public PrivateLobbyConfigDto? PrivateLobbyConfig { get; set; }

    [ProtoMember(10)]
    public bool UseGuid { get; set; }
}
