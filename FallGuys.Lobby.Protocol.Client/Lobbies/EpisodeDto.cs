using System;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Lobbies;

[ProtoContract(Name = "FallGuys_Lobby_EpisodeDto_V1")]
public class EpisodeDto
{
	[ProtoMember(1)]
	public DateTime StartedAt { get; set; }

	[ProtoMember(2)]
	public string? ServerIp { get; set; }

	[ProtoMember(3)]
	public string? ServerPort { get; set; }

	[ProtoMember(4)]
	public string? ServerEntryToken { get; set; }
}
