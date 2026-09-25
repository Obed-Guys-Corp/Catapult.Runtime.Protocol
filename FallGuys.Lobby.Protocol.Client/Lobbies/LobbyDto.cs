using System;
using System.Collections.Generic;
using FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Debug;
using FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Preview;
using FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Private;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Lobbies;

[ProtoContract(Name = "FallGuys_Lobby_LobbyDto_V1")]
public class LobbyDto
{
	private List<LobbyMemberDto>? _members;

	[ProtoMember(1)]
	public string? Id { get; set; }

	[ProtoMember(2)]
	public LobbyState State { get; set; }

	[ProtoMember(3)]
	public List<LobbyMemberDto> Members
	{
		get
		{
			return _members ?? (_members = new List<LobbyMemberDto>());
		}
		set
		{
			_members = value;
		}
	}

	[ProtoMember(4)]
	public LobbyType LobbyType { get; set; }

	[ProtoMember(5)]
	[Obsolete("use PrivateLobbyConfigDto instead")]
	public List<string> ShowIds
	{
		get
		{
			if (PrivateLobbyConfig?.CmsShowConfig?.ShowContentId != null)
			{
				return new List<string> { PrivateLobbyConfig.CmsShowConfig.ShowContentId };
			}
			if (DebugLobbyConfig?.ShowContentId != null)
			{
				return new List<string> { DebugLobbyConfig.ShowContentId };
			}
			return new List<string>();
		}
	}

	[ProtoMember(6)]
	public int MinSizeToStart { get; set; }

	[ProtoMember(7)]
	public int MaxSize { get; set; }

	[ProtoMember(8)]
	public string? RegionId { get; set; }

	[ProtoMember(9)]
	public string? HostPlatformId { get; set; }

	[ProtoMember(10)]
	public bool CrossPlayEnabled { get; set; }

	[ProtoMember(11)]
	public EpisodeDto? Episode { get; set; }

	[ProtoMember(12)]
	public int LatestNotificationId { get; set; }

	[ProtoMember(13)]
	public string? ProfileId { get; set; }

	[ProtoMember(14)]
	public PreviewLobbyConfigDto? PreviewLobbyConfig { get; set; }

	[ProtoMember(15)]
	public PrivateLobbyConfigDto? PrivateLobbyConfig { get; set; }

	[ProtoMember(16)]
	public DebugLobbyConfigDto? DebugLobbyConfig { get; set; }
}
