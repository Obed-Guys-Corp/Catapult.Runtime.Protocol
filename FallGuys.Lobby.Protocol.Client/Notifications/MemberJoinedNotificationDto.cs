using FallGuys.Lobby.Protocol.Client.Lobbies;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Notifications;

[ProtoContract(Name = "FallGuys_Lobby_MemberJoinedNotificationDto_V1")]
public class MemberJoinedNotificationDto
{
	[ProtoMember(1)]
	public string? LobbyId { get; set; }

	[ProtoMember(2)]
	public LobbyMemberDto? Member { get; set; }

	[ProtoMember(3)]
	public int NotificationId { get; set; }
}
