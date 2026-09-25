using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Retrieve;

[ProtoContract(Name = "Catapult_Store_GetAllActiveStoresQuery_V1")]
[Authorize(Roles = new string[] { "User" })]
public class GetAllActiveStoresQuery
{
}
