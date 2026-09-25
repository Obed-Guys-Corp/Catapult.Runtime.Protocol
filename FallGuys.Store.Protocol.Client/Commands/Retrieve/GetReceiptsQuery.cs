using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Retrieve;

[Authorize(Roles = new string[] { "Admin" })]
[ProtoContract(Name = "Catapult_Store_GetAllReceiptsQuery_V1")]
public class GetReceiptsQuery
{
	[ProtoMember(1)]
	public string? UserId { get; set; }
}
