using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Wallet;

[ProtoContract(Name = "FallGuys_PlatformPocketDto_V1")]
public class PlatformPocketDto
{
    private List<string>? _platforms;
    private Dictionary<string, int>? _currencyAmounts;

    [ProtoMember(1)]
    public string? PlatformPocketId { get; set; }

    [ProtoMember(2)]
    public bool IsShared { get; set; }

    [ProtoMember(3)]
    public List<string> Platforms { get; set; }

    [ProtoMember(4)]
    public Dictionary<string, int> CurrencyAmounts { get; set; }
}
