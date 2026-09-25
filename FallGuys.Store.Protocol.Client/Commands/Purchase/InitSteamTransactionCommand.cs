using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "Catapult_Store_InitSteamTransactionCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
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
