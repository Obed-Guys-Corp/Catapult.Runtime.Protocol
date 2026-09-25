using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Rounds;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_Rounds_GetRoundResultsQuery_V1")]
public class GetRoundResultsQuery
{
    [ProtoIgnore]
    private List<string>? _roundIds;

    [ProtoMember(1)]
    public List<string> RoundIds { get; set; }

    [ProtoMember(2)]
    public string? EpisodeId { get; set; }
}
