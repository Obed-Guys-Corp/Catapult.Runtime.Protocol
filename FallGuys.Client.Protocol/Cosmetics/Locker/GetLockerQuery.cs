using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Client.Protocol.Cosmetics.Locker;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FG_Locker_GetLockerQuery_V1")]
public class GetLockerQuery
{
}
