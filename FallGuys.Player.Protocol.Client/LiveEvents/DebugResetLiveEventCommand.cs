using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[ProtoContract(Name = "FallGuys_Player_LiveEvents_DebugResetLiveEventCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class DebugResetLiveEventCommand
{
    [ProtoMember(1)]
    public string? LiveEventId { get; set; }
}
