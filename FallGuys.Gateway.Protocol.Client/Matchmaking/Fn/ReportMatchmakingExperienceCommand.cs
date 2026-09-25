using System;
using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking.Fn;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Matchmaking_ReportMatchmakingExperienceCommand_V1")]
public class ReportMatchmakingExperienceCommand
{
	[ProtoIgnore]
	private List<EventDto>? _events;

	[ProtoMember(1)]
	public string? MetaDataToken { get; set; }

	[ProtoMember(2)]
	public TimeSpan TimeToMatch { get; set; }

	[ProtoMember(3)]
	public MatchmakingResult MatchmakingResult { get; set; }

	[ProtoMember(4)]
	public TimeSpan? TimeToSession { get; set; }

	[ProtoMember(5)]
	public SessionStartResult? SessionStartResult { get; set; }

	[ProtoMember(6)]
	public List<EventDto> Events
	{
		get
		{
			return _events ?? (_events = new List<EventDto>());
		}
		set
		{
			_events = value;
		}
	}
}
