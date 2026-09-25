using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_LiveEvents_DebugResetLiveEventCommand_V1")]
public class DebugResetLiveEventCommand
{
	[ProtoMember(1)]
	public string? LiveEventId { get; set; }
}
