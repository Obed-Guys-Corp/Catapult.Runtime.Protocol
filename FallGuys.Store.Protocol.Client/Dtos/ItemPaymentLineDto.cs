using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_ItemPaymentLineDto_V1")]
public class ItemPaymentLineDto
{
    [ProtoMember(1)]
    public string? Type { get; set; }

    [ProtoMember(2)]
    public string? Id { get; set; }

    [ProtoMember(3)]
    public int? Quantity { get; set; }
}
