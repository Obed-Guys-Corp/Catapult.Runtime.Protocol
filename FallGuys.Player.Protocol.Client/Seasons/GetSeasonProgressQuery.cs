using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Seasons;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_GetSeasonProgressQuery_V1")]
public class GetSeasonProgressQuery
{
    [ProtoMember(1)]
    public string SeasonId { get; set; } = null!;
}
