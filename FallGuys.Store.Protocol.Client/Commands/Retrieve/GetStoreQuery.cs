using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Retrieve;

[ProtoContract(Name = "Catapult_Store_GetStoreQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetStoreQuery
{
    [ProtoMember(1)]
    public string? StoreId { get; set; }
}
