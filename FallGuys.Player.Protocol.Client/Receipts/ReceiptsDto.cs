using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Receipts;

[ProtoContract(Name = "FallGuys_Player_ReceiptsDto_V1")]
public class ReceiptsDto
{
    [ProtoMember(1)]
    public List<PsnReceiptDto> PsnReceipts { get; set; } = null!;

    [ProtoMember(2)]
    public List<SteamReceiptDto> SteamReceipts { get; set; } = null!;

    [ProtoMember(3)]
    public List<SteamDlcReceiptDto> SteamDlcReceipts { get; set; } = null!;

    [ProtoMember(4)]
    public List<AmazonEntitlementReceiptDto> AmazonEntitlementReceipts { get; set; } = null!;
}
