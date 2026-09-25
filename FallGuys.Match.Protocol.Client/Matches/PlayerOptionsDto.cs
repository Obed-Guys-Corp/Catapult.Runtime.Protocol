using ProtoBuf;

namespace FallGuys.Match.Protocol.Client.Matches;

[ProtoContract(Name = "FallGuys_Match_PlayerOptionsDto_V1")]
public class PlayerOptionsDto
{
	[ProtoMember(1)]
	public int? WinBuff { get; set; }

	[ProtoMember(2)]
	public int? FirstGameOfTheDayDebuff { get; set; }

	[ProtoMember(3)]
	public int? LossStreakDebuff { get; set; }

	[ProtoMember(4)]
	public int? InactivityDebuff { get; set; }
}
