using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Wallet;

[ProtoContract(Name = "FallGuys_PlatformPocketDto_V1")]
public class PlatformPocketDto
{
    [ProtoMember(1)]
    public string? PlatformPocketId { get; set; }

    [ProtoMember(2)]
    public bool IsShared { get; set; }

    [ProtoMember(3)]
    public List<string> Platforms { get; set; } = null!;

    [ProtoMember(4)]
    public Dictionary<string, int> CurrencyAmounts { get; set; } = null!;
}
