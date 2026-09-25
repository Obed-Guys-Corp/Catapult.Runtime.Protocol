using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Lobbies;

[ProtoContract(Name = "FallGuys_Lobby_LobbyState_V1")]
public enum LobbyState
{
    [ProtoEnum(Name = "unknown")]
    Unknown,
    [ProtoEnum(Name = "populating")]
    Populating,
    [ProtoEnum(Name = "matchmaking")]
    Matchmaking,
    [ProtoEnum(Name = "episode_in_progress")]
    EpisodeInProgress,
    [ProtoEnum(Name = "closed")]
    Closed
}
