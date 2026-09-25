using System;
using System.Collections.Generic;
using Catapult.Protocol;
using FallGuys.Player.Protocol.Client.Metrics;
using FallGuys.Player.Protocol.Client.Reputation;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_ProcessCompletedRoundCommand_V1")]
public class ProcessCompletedRoundCommand
{
	private List<MetricUpdateCollection>? _metricUpdateCollections;

	private Dictionary<string, PlayerMetricUpdateDto>? _metricUpdates;

	[ProtoMember(1)]
	public string? EpisodeId { get; set; }

	[ProtoMember(2)]
	public int RoundIndex { get; set; }

	[ProtoMember(3)]
	public int? TeamScore { get; set; }

	[ProtoMember(4)]
	public int? Position { get; set; }

	[ProtoMember(5)]
	public bool Qualified { get; set; }

	[ProtoMember(6)]
	public bool IsFinalRound { get; set; }

	[ProtoMember(7)]
	public string? PlayerId { get; set; }

	[ProtoMember(8)]
	public string? ContentVersion { get; set; }

	[ProtoMember(9)]
	[Obsolete("Use MetricUpdateCollections instead.")]
	public Dictionary<string, PlayerMetricUpdateDto> MetricUpdates
	{
		get
		{
			return _metricUpdates ?? (_metricUpdates = new Dictionary<string, PlayerMetricUpdateDto>());
		}
		set
		{
			_metricUpdates = value;
		}
	}

	[ProtoMember(10)]
	public string? LevelId { get; set; }

	[ProtoMember(11)]
	public int? Possession { get; set; }

	[ProtoMember(12)]
	public int? TeamPosition { get; set; }

	[ProtoMember(13)]
	public int? FinishedInPositionBracket { get; set; }

	[ProtoMember(14)]
	public bool WentIntoOvertime { get; set; }

	[ProtoMember(15)]
	public int PartySize { get; set; }

	[ProtoMember(16)]
	public InfractionsSummaryDto? InfractionsSummary { get; set; }

	[ProtoMember(17)]
	public string? ShowId { get; set; }

	[ProtoMember(18)]
	public bool IsPrivateLobby { get; set; }

	[ProtoMember(19)]
	public int NumberOfQualifiedPlayers { get; set; }

	[ProtoMember(20)]
	public string? TeamId { get; set; }

	[ProtoMember(21)]
	[Obsolete("It was only used for the deprecated server solo score metric")]
	public int? SoloScore { get; set; }

	[ProtoMember(22)]
	public bool IsInSquad { get; set; }

	[ProtoMember(23)]
	public string? PlayerActionState { get; set; }

	[ProtoMember(24)]
	public int? PlayerRespawnCount { get; set; }

	[ProtoMember(25)]
	public bool FellInSlime { get; set; }

	[ProtoMember(26)]
	public int? QualifyTime { get; set; }

	[ProtoMember(27)]
	public int? TeamGoalsScored { get; set; }

	[ProtoMember(28)]
	public int? HoopsDivedThrough { get; set; }

	[ProtoMember(29)]
	public int? TimeSurvived { get; set; }

	[ProtoMember(30)]
	public List<MetricUpdateCollection> MetricUpdateCollections
	{
		get
		{
			return _metricUpdateCollections ?? (_metricUpdateCollections = new List<MetricUpdateCollection>());
		}
		set
		{
			_metricUpdateCollections = value;
		}
	}

	[ProtoMember(31)]
	public UgcLevel? UgcLevel { get; set; }
}
