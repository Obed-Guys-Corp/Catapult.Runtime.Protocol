using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Retrieve;

[ProtoContract(Name = "FallGuys_Store_GetAllSymphonyStoresQuery_V1")]
[Authorize(Roles = new string[] { "User" })]
public class GetAllSymphonyStoresQuery
{
}
