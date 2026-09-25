using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "Catapult_Store_PurchaseBundleCommand_PaymentOption_V1")]
public class PaymentOption
{
	public virtual int GetOptionOrDefault()
	{
		return -1;
	}
}
