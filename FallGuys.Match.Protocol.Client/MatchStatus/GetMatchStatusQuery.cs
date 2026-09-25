using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Match.Protocol.Client.MatchStatus;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Match_GetMatchStatusQuery_V1")]
public class GetMatchStatusQuery
{
	[ProtoMember(1)]
	public string? MatchId { get; set; }
}
