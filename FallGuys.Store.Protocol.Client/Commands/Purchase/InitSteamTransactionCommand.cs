using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "Catapult_Store_InitSteamTransactionCommand_V1")]
public class InitSteamTransactionCommand
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
