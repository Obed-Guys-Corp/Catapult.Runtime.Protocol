using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rewards;

[ProtoContract(Name = "FallGuys_Player_UnclaimedRewardsDto_V1")]
public class UnclaimedRewardsDto
{
	private List<RewardDto>? _rewards;

	[ProtoMember(1)]
	public List<RewardDto> Rewards
	{
		get
		{
			return _rewards ?? (_rewards = new List<RewardDto>());
		}
		set
		{
			_rewards = value;
		}
	}
}
