using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rewards;

[ProtoContract(Name = "FallGuys_Client_ClaimedRewardsDto_V1")]
public class ClaimedRewardsDto
{
	private Dictionary<string, RewardClaimedDto>? _claimedRewards;

	[ProtoMember(1)]
	public Dictionary<string, RewardClaimedDto> ClaimedRewards
	{
		get
		{
			return _claimedRewards ?? (_claimedRewards = new Dictionary<string, RewardClaimedDto>());
		}
		set
		{
			_claimedRewards = value;
		}
	}

	[ProtoMember(2)]
	public UnclaimedRewardsDto? UnclaimedRewards { get; set; }
}
