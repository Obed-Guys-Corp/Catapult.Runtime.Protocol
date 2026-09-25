using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Profile;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_GetProfileQuery_V1")]
public class GetProfileQuery
{
}
