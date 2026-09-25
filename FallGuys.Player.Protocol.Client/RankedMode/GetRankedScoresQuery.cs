using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.RankedMode;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_RankedMode_GetRankedScoresQuery_V1")]
public class GetRankedScoresQuery
{
    [ProtoMember(1)]
    public string[]? Chainkeys { get; set; }
}
