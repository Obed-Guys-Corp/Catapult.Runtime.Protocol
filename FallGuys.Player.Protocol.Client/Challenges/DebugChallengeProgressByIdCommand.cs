using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges;

[ProtoContract(Name = "FallGuys_Player_DebugChallengeProgressByIdCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
[DebugMessage]
public class DebugChallengeProgressByIdCommand
{
    [ProtoMember(1)]
    public string? ChallengeId { get; set; }

    [ProtoMember(2)]
    public int? Value { get; set; }
}
