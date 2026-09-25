using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_UnclaimedFameTierRewardDto_V1")]
public class UnclaimedFameTierRewardDto
{
	[ProtoMember(1)]
	public string? RewardId { get; set; }

	[ProtoMember(2)]
	public string? SeasonPassContentId { get; set; }

	[ProtoMember(3)]
	public string? RewardContentId { get; set; }
}
