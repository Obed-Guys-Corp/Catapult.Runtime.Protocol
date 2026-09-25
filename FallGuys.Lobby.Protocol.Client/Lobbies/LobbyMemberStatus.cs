using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Lobbies;

[ProtoContract(Name = "FallGuys_Lobby_LobbyMemberReadyStatus_V1")]
public enum LobbyMemberStatus
{
    [ProtoEnum(Name = "unknown")]
    Unknown,
    [ProtoEnum(Name = "not_ready")]
    NotReady,
    [ProtoEnum(Name = "ready")]
    Ready,
    [ProtoEnum(Name = "matchmaking")]
    Matchmaking,
    [ProtoEnum(Name = "request_cancel_user_initiated")]
    RequestCancelUserInitiated,
    [ProtoEnum(Name = "request_cancel_error")]
    RequestCancelError,
    [ProtoEnum(Name = "returning_to_lobby")]
    ReturningToLobby,
    [ProtoEnum(Name = "playing")]
    Playing,
    [ProtoEnum(Name = "spectating_eliminated")]
    SpectatingEliminated,
    [ProtoEnum(Name = "spectating_qualified")]
    SpectatingQualified
}
