using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.PurchaseHistory.Dto;

[ProtoContract(Name = "FallGuys_PurchaseHistory_ReturnTicketDto_V1")]
public class ReturnTicketDto
{
    [ProtoMember(1)]
    public int Quantity { get; set; }

    [ProtoMember(2)]
    public int MaxNumber { get; set; }

    [ProtoMember(3)]
    public DateTime NextTicketAt { get; set; }
}
