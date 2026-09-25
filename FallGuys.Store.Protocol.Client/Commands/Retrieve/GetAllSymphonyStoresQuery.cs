using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Retrieve;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Store_GetAllSymphonyStoresQuery_V1")]
public class GetAllSymphonyStoresQuery
{
}
