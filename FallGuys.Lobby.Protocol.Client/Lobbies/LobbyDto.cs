using FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Debug;
using FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Preview;
using FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Private;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Lobby.Protocol.Client.Lobbies;

[ProtoContract(Name = "FallGuys_Lobby_LobbyDto_V1")]
public class LobbyDto
{
    [ProtoMember(1)]
    public string? Id { get; set; }

    [ProtoMember(2)]
    public LobbyState State { get; set; }

    [ProtoMember(3)]
    public List<LobbyMemberDto> Members { get; set; } = null!;

    [ProtoMember(4)]
    public LobbyType LobbyType { get; set; }

    [ProtoMember(5)]
    [Obsolete("use PrivateLobbyConfigDto instead")]
    public List<string> ShowIds { get; } = null!;

    [ProtoMember(6)]
    public int MinSizeToStart { get; set; }

    [ProtoMember(7)]
    public int MaxSize { get; set; }

    [ProtoMember(8)]
    public string? RegionId { get; set; }

    [ProtoMember(9)]
    public string? HostPlatformId { get; set; }

    [ProtoMember(10)]
    public bool CrossPlayEnabled { get; set; }

    [ProtoMember(11)]
    public EpisodeDto? Episode { get; set; }

    [ProtoMember(12)]
    public int LatestNotificationId { get; set; }

    [ProtoMember(13)]
    public string? ProfileId { get; set; }

    [ProtoMember(14)]
    public PreviewLobbyConfigDto? PreviewLobbyConfig { get; set; }

    [ProtoMember(15)]
    public PrivateLobbyConfigDto? PrivateLobbyConfig { get; set; }

    [ProtoMember(16)]
    public DebugLobbyConfigDto? DebugLobbyConfig { get; set; }
}
