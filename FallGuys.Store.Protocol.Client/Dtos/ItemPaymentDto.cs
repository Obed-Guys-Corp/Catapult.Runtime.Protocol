using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_ItemPaymentOptionDto_V1")]
public class ItemPaymentDto : PaymentDto
{
    [ProtoMember(1)]
    public List<ItemPaymentLineDto> Items { get; set; } = null!;
}
