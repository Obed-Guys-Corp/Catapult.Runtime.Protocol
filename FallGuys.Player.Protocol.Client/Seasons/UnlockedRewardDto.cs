using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Seasons;

[ProtoContract(Name = "FallGuys_Player_SeasonFameTierRewardDto_V1")]
public class UnlockedRewardDto
{
	[ProtoMember(1)]
	public string? RewardId { get; set; }

	[ProtoMember(2)]
	public string? SeasonPassContentId { get; set; }

	[ProtoMember(3)]
	public string? RewardContentId { get; set; }
}
