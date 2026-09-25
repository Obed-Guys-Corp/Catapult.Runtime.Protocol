using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_IapPaymentDto_V1")]
public class IapPaymentDto : PaymentDto
{
    [ProtoMember(1)]
    public string? IapId { get; set; }
}
