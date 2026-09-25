using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Notifications;

[ProtoContract(Name = "FallGuys_Lobby_MemberLeftNotificationDto_V1")]
public class MemberLeftNotificationDto
{
	[ProtoMember(1)]
	public string? LobbyId { get; set; }

	[ProtoMember(2)]
	public string? MemberId { get; set; }

	[ProtoMember(3)]
	public int NotificationId { get; set; }

	[ProtoMember(4)]
	public string? HostId { get; set; }
}
