using System;
using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.SelectShows;

[ProtoContract(Name = "FallGuys_Lobby_SelectShowsCommand_V1")]
[Authorize(Roles = new string[] { "User" })]
[Obsolete("Use SelectNextShowCommand instead")]
public class SelectShowsCommand
{
	[ProtoIgnore]
	private List<string>? _showIds;

	[ProtoMember(1)]
	public string? LobbyId { get; set; }

	[ProtoMember(2)]
	public List<string> ShowIds
	{
		get
		{
			return _showIds ?? (_showIds = new List<string>());
		}
		set
		{
			_showIds = value;
		}
	}
}
