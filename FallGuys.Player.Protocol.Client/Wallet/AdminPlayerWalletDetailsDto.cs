using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Wallet;

[ProtoContract(Name = "FallGuys_Player_AdminPlayerWalletDetailsDto_V1")]
public class AdminPlayerWalletDetailsDto
{
    [ProtoMember(1)]
    public int KudosGranted { get; set; }

    [ProtoMember(2)]
    public int KudosTotalPlatformShared { get; set; }

    [ProtoMember(3)]
    public Dictionary<string, int> KudosNotShared { get; set; } = null!;

    [ProtoMember(4)]
    public int ShowBucksGranted { get; set; }

    [ProtoMember(5)]
    public int ShowBucksTotalPlatformShared { get; set; }

    [ProtoMember(6)]
    public Dictionary<string, int> ShowBucksNotShared { get; set; } = null!;

    [ProtoMember(7)]
    public Dictionary<string, CurrencyDetailsDto> CurrenciesByContentItemId { get; set; } = null!;
}
