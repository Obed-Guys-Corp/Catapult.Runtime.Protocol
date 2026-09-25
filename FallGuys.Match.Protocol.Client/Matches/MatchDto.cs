using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Match.Protocol.Client.Matches;

[ProtoContract(Name = "FallGuys_Match_MatchDto_V1")]
public class MatchDto
{
	private List<PartyDto>? _parties;

	[ProtoMember(7)]
	public string? FortniteMatchId { get; set; }

	[ProtoMember(1)]
	public string? BucketId { get; set; }

	[ProtoMember(2)]
	public string? SubRegionId { get; set; }

	[ProtoMember(3)]
	public int? MedianAbilityScore { get; set; }

	[ProtoMember(4)]
	public List<PartyDto> Parties
	{
		get
		{
			return _parties ?? (_parties = new List<PartyDto>());
		}
		set
		{
			_parties = value;
		}
	}

	[ProtoMember(5)]
	public int NumBots { get; set; }
}
