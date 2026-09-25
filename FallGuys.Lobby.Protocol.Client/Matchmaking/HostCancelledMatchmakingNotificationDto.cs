using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Matchmaking;

[ProtoContract(Name = "FallGuys_Lobby_HostCancelledMatchmakingNotificationDto_V1")]
public class HostCancelledMatchmakingNotificationDto
{
    [ProtoMember(1)]
    public string LobbyId { get; set; } = null!;

    [ProtoMember(2)]
    public int NotificationId { get; set; }
}
