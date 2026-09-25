using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rewards;

[ProtoContract(Name = "FallGuys_Client_RewardClaimResultDto_V1")]
public class BulkRewardClaimResult
{
	[ProtoMember(1)]
	public Dictionary<string, RewardClaimedDto> ClaimedRewards { get; set; }

	[ProtoMember(2)]
	public List<RewardDto> UnclaimedRewards { get; set; }

	[ProtoMember(3)]
	public List<RewardDto> UnclaimedChoiceRewards { get; set; }
}
