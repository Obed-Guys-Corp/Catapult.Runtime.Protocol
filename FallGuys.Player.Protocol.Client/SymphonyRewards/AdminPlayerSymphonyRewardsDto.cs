using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.SymphonyRewards;

[ProtoContract(Name = "FallGuys_AdminPlayerSymphonyRewardsDto_V1")]
[Authorize(Roles = new string[] { "Admin" })]
public class AdminPlayerSymphonyRewardsDto
{
	[ProtoIgnore]
	private List<SymphonyRewardDto>? _rewards;

	[ProtoMember(1)]
	public List<SymphonyRewardDto> Rewards
	{
		get
		{
			return _rewards ?? (_rewards = new List<SymphonyRewardDto>());
		}
		set
		{
			_rewards = value;
		}
	}

	[ProtoMember(2)]
	public SymphonyConversionDto? SymphonyConversion { get; set; }
}
