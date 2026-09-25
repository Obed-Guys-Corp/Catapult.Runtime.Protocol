using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges;

[DebugMessage]
[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_DebugResetChallengeProgressByIdCommand_V1")]
public class DebugResetChallengeProgressByIdCommand
{
	[ProtoMember(1)]
	public string? ChallengeId { get; set; }
}
