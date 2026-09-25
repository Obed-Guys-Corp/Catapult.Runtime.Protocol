using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Client.Protocol.Rounds.InitRoundCommand;

[ProtoContract(Name = "FallGuys_Rounds_InitRoundCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.GameServer })]
public class InitRoundCommand
{
    [ProtoMember(1)]
    public string? SessionId { get; set; }

    [ProtoMember(2)]
    public string? ShowContentId { get; set; }

    [ProtoMember(3)]
    public int RoundIndex { get; set; }
}
