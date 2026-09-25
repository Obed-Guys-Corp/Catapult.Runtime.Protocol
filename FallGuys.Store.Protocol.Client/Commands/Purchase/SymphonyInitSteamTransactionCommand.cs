using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Store_SymphonyInitSteamTransactionCommand_V1")]
public class SymphonyInitSteamTransactionCommand
{
	[ProtoMember(1)]
	public string? IapId { get; set; }

	[ProtoMember(2)]
	public ulong SteamId { get; set; }

	[ProtoMember(3)]
	public PurchaseIapRegionPrice? ExpectedRegionPrice { get; set; }

	[ProtoMember(4)]
	public string? DisplayName { get; set; }
}
