using System;
using System.Collections.Generic;
using FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Debug;
using FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Private;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Notifications;

[ProtoContract(Name = "FallGuys_Lobby_ShowsSelectedNotificationDto_V1")]
public class ShowsSelectedNotificationDto
{
	[ProtoIgnore]
	private List<string>? _showIds;

	[ProtoMember(1)]
	public string? LobbyId { get; set; }

	[Obsolete("use PrivateLobbyConfigDto or DebugLobbyConfigDto instead")]
	[ProtoMember(2)]
	public List<string> ShowIds
	{
		get
		{
			if (_showIds != null)
			{
				return _showIds;
			}
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
		set
		{
			_showIds = value;
		}
	}

	[ProtoMember(3)]
	public int NotificationId { get; set; }

	[Obsolete("use PrivateLobbyConfigDto or DebugLobbyConfigDto instead")]
	[ProtoMember(4)]
	public string? ShowId
	{
		get
		{
			object obj = PrivateLobbyConfig?.CmsShowConfig?.ShowContentId;
			if (obj == null)
			{
				DebugLobbyConfigDto? debugLobbyConfig = DebugLobbyConfig;
				if (debugLobbyConfig == null)
				{
					return null;
				}
				obj = debugLobbyConfig.ShowContentId;
			}
			return (string?)obj;
		}
		set
		{
		}
	}

	[ProtoMember(5)]
	public LobbyType LobbyType { get; set; }

	[ProtoMember(6)]
	public PrivateLobbyConfigDto? PrivateLobbyConfig { get; set; }

	[ProtoMember(7)]
	public DebugLobbyConfigDto? DebugLobbyConfig { get; set; }
}
