using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Seasons;

[ProtoContract(Name = "FallGuys_Player_GetSeasonProgressQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetSeasonProgressQuery
{
	[ProtoMember(1)]
	public string SeasonId { get; set; }
}
