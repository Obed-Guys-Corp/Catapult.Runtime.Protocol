using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_GetLoadoutQuery_V1")]
public class GetLoadoutQuery
{
}
