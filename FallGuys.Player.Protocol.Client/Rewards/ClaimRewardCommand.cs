using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rewards;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_ClaimRewardCommand_V1")]
public class ClaimRewardCommand
{
	[ProtoMember(1)]
	public string RewardId { get; set; }

	[ProtoMember(2)]
	public string Choice { get; set; }
}
