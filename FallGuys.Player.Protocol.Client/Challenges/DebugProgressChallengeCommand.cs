using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges;

[DebugMessage]
[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_DebugProgressChallengeCommand_V1")]
public class DebugProgressChallengeCommand
{
	[ProtoMember(1)]
	public string? GoalId { get; set; }

	[ProtoMember(2)]
	public int Progress { get; set; }
}
