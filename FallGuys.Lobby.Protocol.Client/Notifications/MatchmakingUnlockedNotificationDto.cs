using FallGuys.Lobby.Protocol.Client.Matchmaking;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Notifications;

[ProtoContract(Name = "Fg_Lobby_MatchmakingUnlockedNotificationDto")]
public class MatchmakingUnlockedNotificationDto
{
    [ProtoMember(1)]
    public string? LobbyId { get; set; }

    [ProtoMember(2)]
    public int NotificationId { get; set; }

    [ProtoMember(3)]
    public LobbyMatchmakingTokenDto? Token { get; set; }
}
