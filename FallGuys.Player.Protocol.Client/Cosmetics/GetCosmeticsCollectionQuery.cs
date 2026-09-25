using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[ProtoContract(Name = "FallGuys_GetCosmeticsCollectionQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetCosmeticsCollectionQuery
{
}
