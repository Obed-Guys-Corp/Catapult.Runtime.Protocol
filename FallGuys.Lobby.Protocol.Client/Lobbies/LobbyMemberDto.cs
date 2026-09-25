using System;
using FallGuys.Lobby.Protocol.Common;
using FallGuys.Lobby.Protocol.Common.Lobbies;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Lobbies;

[ProtoContract(Name = "FallGuys_Lobby_LobbyMemberDto_V1")]
public class LobbyMemberDto
{
	[ProtoMember(1)]
	public string? Id { get; set; }

	[ProtoMember(2)]
	public DateTime JoinedAt { get; set; }

	[ProtoMember(3)]
	public LobbyMemberRole Role { get; set; }

	[ProtoMember(4)]
	public string? PlatformId { get; set; }

	[ProtoMember(5)]
	public string? PlatformAccountId { get; set; }

	[ProtoMember(6)]
	public string? ExternalAccountName { get; set; }

	[ProtoMember(7)]
	public LobbyMemberStatus Status { get; set; }

	[ProtoMember(8)]
	public CosmeticLoadoutDto? Loadout { get; set; }

	[ProtoMember(9)]
	public LobbyMemberNameDto? InternalAccountName { get; set; }

	[ProtoMember(10)]
	public int? ContentTargetingIndex { get; set; }

	[ProtoMember(11)]
	public ShowRole ShowRole { get; set; }
}
