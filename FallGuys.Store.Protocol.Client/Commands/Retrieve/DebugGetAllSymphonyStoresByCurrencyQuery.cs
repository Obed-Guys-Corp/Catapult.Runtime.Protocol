using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Retrieve;

[ProtoContract(Name = "FallGuys_Store_GetAllSymphonyStoresByCurrencyQuery_V1")]
[Authorize(Roles = new string[] { "User" })]
[DebugMessage]
public class DebugGetAllSymphonyStoresByCurrencyQuery
{
	[ProtoMember(1)]
	public string? CountryIso { get; set; }

	[ProtoMember(2)]
	public string? CurrencyIso { get; set; }
}
