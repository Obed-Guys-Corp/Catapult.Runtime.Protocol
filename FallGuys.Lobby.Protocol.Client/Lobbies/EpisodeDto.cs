using FallGuys.Client.Protocol.GameServers;
using FallGuys.Lobby.Protocol.Client.Matchmaking;
using ProtoBuf;
using System;

namespace FallGuys.Lobby.Protocol.Client.Lobbies;

[ProtoContract(Name = "FallGuys_Lobby_EpisodeDto_V1")]
public class EpisodeDto
{
    [ProtoMember(1)]
    public DateTime StartedAt { get; set; }

    [ProtoMember(2)]
    public string? ServerIp { get; set; }

    [ProtoMember(3)]
    public string? ServerPort { get; set; }

    [ProtoMember(4)]
    public string? ServerEntryToken { get; set; }

    [ProtoMember(5)]
    public GameServerConnectionDto? GameServer { get; set; }

    [ProtoMember(6)]
    public LobbyMatchmakingTokenDto? MatchmakingToken { get; set; }
}
