using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Notifications;

[ProtoContract(Name = "FallGuys_Lobby_LobbyClearedNotificationDto_V1")]
public class LobbyClearedNotificationDto
{
    [ProtoMember(1)]
    public string LobbyId { get; set; }

    [ProtoMember(2)]
    public int NotificationId { get; set; }
}
