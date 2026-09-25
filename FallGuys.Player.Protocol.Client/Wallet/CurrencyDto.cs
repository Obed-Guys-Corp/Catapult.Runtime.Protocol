using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Wallet;

[ProtoContract(Name = "FallGuys_Player_Wallet_CurrencyDto_V1")]
public class CurrencyDto
{
    [ProtoMember(1)]
    public string? ContentItemId { get; set; }

    [ProtoMember(2)]
    public bool IsShared { get; set; }

    [ProtoMember(3)]
    public int EarnedBalance { get; set; }

    [ProtoMember(4)]
    public Dictionary<string, int> PurchaseBalanceByPocketId { get; set; } = null!;
}
