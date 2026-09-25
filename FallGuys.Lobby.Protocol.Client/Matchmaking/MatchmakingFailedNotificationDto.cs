using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Matchmaking;

[ProtoContract(Name = "FallGuys_Lobby_MatchmakingFailedNotificationDto_V1")]
public class MatchmakingFailedNotificationDto
{
    [ProtoMember(1)]
    public string LobbyId { get; set; } = null!;

    [ProtoMember(2)]
    public int NotificationId { get; set; }
}
