using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "Catapult_Store_Protocol_PurchaseBundleCommand_AndroidReceiptPayment_V1")]
public class AndroidReceiptPaymentOption : PaymentOption
{
    [ProtoMember(1)]
    public string? Receipt { get; set; }

    [ProtoMember(2)]
    public string? Signature { get; set; }
}
