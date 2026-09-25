using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_DebugCompleteChallengeByIdCommand_V1")]
[DebugMessage]
public class DebugCompleteChallengeByIdCommand
{
	[ProtoMember(1)]
	public string? ChallengeId { get; set; }
}
