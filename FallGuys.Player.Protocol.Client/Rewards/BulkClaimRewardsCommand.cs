using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rewards;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_BulkClaimRewardsCommand_V1")]
public class BulkClaimRewardsCommand
{
	[ProtoMember(1)]
	public List<string> RewardIds { get; set; }
}
