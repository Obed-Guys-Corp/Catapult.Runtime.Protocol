using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_NoPaymentOptionDto_V1")]
public class NoPaymentDto : PaymentDto
{
}
