using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Wallet;

[ProtoContract(Name = "FallGuys_WalletDto_V1")]
public class WalletDto
{
    private Dictionary<string, int>? _currencyAmounts;

    [ProtoMember(1)]
    public int Kudos { get; set; }

    [ProtoMember(2)]
    public int Crowns { get; set; }

    [ProtoMember(3)]
    public int CrownShards { get; set; }

    [Obsolete("No longer used")]
    [ProtoMember(4)]
    public int GemsPurchased { get; set; }

    [ProtoMember(5)]
    public int GemsGranted { get; set; }

    [ProtoMember(6)]
    public Dictionary<string, int> CurrencyAmounts { get; set; }
}
