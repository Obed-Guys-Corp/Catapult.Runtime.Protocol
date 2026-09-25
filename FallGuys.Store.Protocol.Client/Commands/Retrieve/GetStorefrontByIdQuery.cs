using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Retrieve;

[ProtoContract(Name = "FallGuys_Store_GetStorefrontByIdQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetStorefrontByIdQuery
{
    [ProtoMember(1)]
    public string? StorefrontId { get; set; }
}
