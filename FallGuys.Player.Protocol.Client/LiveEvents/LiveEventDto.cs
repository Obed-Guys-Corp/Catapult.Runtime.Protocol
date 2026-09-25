using System;
using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[ProtoContract(Name = "FallGuys_Player_LiveEventDto_V1")]
public class LiveEventDto
{
	private List<LiveEventChallengeDto>? _goals;

	private List<LiveEventMilestoneDto>? _milestones;

	[ProtoMember(1)]
	public string? ContentId { get; set; }

	[ProtoMember(2)]
	public DateTime? StartsAt { get; set; }

	[ProtoMember(3)]
	public DateTime? EndsAt { get; set; }

	[ProtoMember(4)]
	public List<LiveEventChallengeDto> Goals
	{
		get
		{
			return _goals ?? (_goals = new List<LiveEventChallengeDto>());
		}
		set
		{
			_goals = value;
		}
	}

	[ProtoMember(5)]
	public List<LiveEventMilestoneDto> Milestones
	{
		get
		{
			return _milestones ?? (_milestones = new List<LiveEventMilestoneDto>());
		}
		set
		{
			_milestones = value;
		}
	}

	[ProtoMember(6)]
	public bool IsCompleted { get; set; }

	[ProtoMember(7)]
	public string? Id { get; set; }
}
