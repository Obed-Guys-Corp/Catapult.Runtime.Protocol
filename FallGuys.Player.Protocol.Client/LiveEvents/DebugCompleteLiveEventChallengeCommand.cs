using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[ProtoContract(Name = "FallGuys_Player_LiveEvents_DebugCompleteLiveEventChallengeCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class DebugCompleteLiveEventChallengeCommand
{
	[ProtoMember(1)]
	public string? GoalId { get; set; }
}
