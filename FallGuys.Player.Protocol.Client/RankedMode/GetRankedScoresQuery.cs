using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.RankedMode;

[ProtoContract(Name = "FallGuys_Player_RankedMode_GetRankedScoresQuery_V1")]
[Authorize(Roles = new string[] { "User" })]
public class GetRankedScoresQuery
{
	[ProtoMember(1)]
	public string[]? Chainkeys { get; set; }
}
