using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Notifications;

[ProtoContract(Name = "FallGuys_Lobby_MemberKickedNotificationDto_V1")]
public class MemberKickedNotificationDto
{
    [ProtoMember(1)]
    public string? LobbyId { get; set; }

    [ProtoMember(2)]
    public string? MemberId { get; set; }

    [ProtoMember(3)]
    public int NotificationId { get; set; }
}
