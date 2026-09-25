using FallGuys.Lobby.Protocol.Client.Lobbies;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Matchmaking;

[ProtoContract(Name = "FallGuys_Lobby_EpisodeStartingNotificationDto_V1")]
public class EpisodeStartingNotificationDto
{
	[ProtoMember(1)]
	public string? LobbyId { get; set; }

	[ProtoMember(2)]
	public EpisodeDto? Episode { get; set; }

	[ProtoMember(3)]
	public int NotificationId { get; set; }
}
