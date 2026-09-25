using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.AbilityPoints;

[ProtoContract(Name = "FallGuys_Player_DebugOverridePointsHistoryCommand_V1")]
[DebugMessage]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class DebugOverridePointsHistoryCommand
{
    [ProtoMember(1)]
    public int NewPointsHistoryCount { get; set; }
}
