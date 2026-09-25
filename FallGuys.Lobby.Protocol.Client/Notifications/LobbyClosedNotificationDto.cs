using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Notifications;

[ProtoContract(Name = "FallGuys_Lobby_LobbyClosedNotificationDto_V1")]
public class LobbyClosedNotificationDto
{
    [ProtoMember(1)]
    public string LobbyId { get; set; }

    [ProtoMember(2)]
    public int NotificationId { get; set; }
}
