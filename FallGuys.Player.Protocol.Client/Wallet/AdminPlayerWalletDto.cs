using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Wallet;

[ProtoContract(Name = "FallGuys_AdminPlayerWalletDto_V1")]
public class AdminPlayerWalletDto
{
    private Dictionary<string, PlatformPocketDto>? _platformsPockets;
    private Dictionary<string, CurrencyDto>? _currenciesByContentItemId;

    [ProtoMember(1)]
    public int Kudos { get; set; }

    [ProtoMember(2)]
    public int Crowns { get; set; }

    [ProtoMember(3)]
    public int CrownShards { get; set; }

    [ProtoMember(4)]
    public int Gems { get; set; }

    [ProtoMember(5)]
    public bool IsWalletMigrationCompleted { get; set; }

    [ProtoMember(6)]
    public Dictionary<string, PlatformPocketDto> PlatformPockets { get; set; }

    [ProtoMember(7)]
    public bool IsCrownToKudosConversionCompleted { get; set; }

    [ProtoMember(8)]
    public Dictionary<string, CurrencyDto> CurrenciesByContentItemId { get; set; }
}
