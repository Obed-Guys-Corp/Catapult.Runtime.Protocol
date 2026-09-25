using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_MarkChallengeGroupAsSeenCommand_V1")]
public class MarkChallengeGroupAsSeenCommand
{
	[ProtoMember(1)]
	public string? ChallengeGroupId { get; set; }
}
