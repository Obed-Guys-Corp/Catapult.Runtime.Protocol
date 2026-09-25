using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.RankedMode;

[DebugMessage]
[ProtoContract(Name = "FallGuys_Player_RankedMode_DebugOverrideRankedScoreCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class DebugOverrideRankedScoreCommand
{
    [ProtoMember(1)]
    public string? Chainkey { get; set; }

    [ProtoMember(2)]
    public int ScoreOverride { get; set; }
}
