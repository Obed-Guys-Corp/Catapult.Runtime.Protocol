using FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Debug;
using FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Private;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Lobby.Protocol.Client.Notifications;

[ProtoContract(Name = "FallGuys_Lobby_ShowsSelectedNotificationDto_V1")]
public class ShowsSelectedNotificationDto
{
    [ProtoIgnore]
    private List<string>? _showIds;

    [ProtoMember(1)]
    public string? LobbyId { get; set; }

    [Obsolete("use PrivateLobbyConfigDto or DebugLobbyConfigDto instead")]
    [ProtoMember(2)]
    public List<string> ShowIds { get; set; }

    [ProtoMember(3)]
    public int NotificationId { get; set; }

    [Obsolete("use PrivateLobbyConfigDto or DebugLobbyConfigDto instead")]
    [ProtoMember(4)]
    public string? ShowId { get; set; }

    [ProtoMember(5)]
    public LobbyType LobbyType { get; set; }

    [ProtoMember(6)]
    public PrivateLobbyConfigDto? PrivateLobbyConfig { get; set; }

    [ProtoMember(7)]
    public DebugLobbyConfigDto? DebugLobbyConfig { get; set; }
}
