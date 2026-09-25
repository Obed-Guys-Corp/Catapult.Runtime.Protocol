using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[ProtoContract(Name = "FallGuys_Player_GetLiveEventsQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetLiveEventsQuery
{
}
