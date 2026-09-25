using System;
using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges;

[ProtoContract(Name = "FallGuys_Player_ChallengeGroupDto_V1")]
public class ChallengeGroupDto
{
	[ProtoIgnore]
	private List<ChallengeDto>? _challenges;

	[ProtoMember(1)]
	public string? Id { get; set; }

	[Obsolete("Use ChallengeGroupContentId")]
	[ProtoMember(2)]
	public string? ChallengeContentId { get; set; }

	[ProtoMember(6)]
	public string? ChallengeGroupContentId { get; set; }

	[ProtoMember(3)]
	public List<ChallengeDto> Challenges
	{
		get
		{
			return _challenges ?? (_challenges = new List<ChallengeDto>());
		}
		set
		{
			_challenges = value;
		}
	}

	[ProtoMember(4)]
	public DateTime? NextRefreshDate { get; set; }

	[ProtoMember(5)]
	public bool IsSeen { get; set; }
}
