using ProtoBuf;

namespace Catapult.Services.Gateway.Protocol.Client;

[ProtoContract(Name = "Catapult_Gateway_SessionClosedMessage_V1")]
public class SessionClosedMessage
{
	[ProtoMember(1)]
	public SessionClosedReason Reason { get; set; }
}
