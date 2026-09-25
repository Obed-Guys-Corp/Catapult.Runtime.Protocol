using ProtoBuf;

namespace Catapult.Protocol.Headers;

[ProtoContract(Name = "Catapult_OperationHeader_V1")]
public class OperationHeader : MessageHeader
{
	[ProtoMember(1)]
	public Guid RequestId { get; set; }

	[ProtoMember(2)]
	public OperationType Type { get; set; }

	public OperationHeader(Guid requestId, OperationType type)
	{
		RequestId = requestId;
		Type = type;
	}

	public OperationHeader()
	{
	}

	public override string ToString()
	{
		return $"OperationHeader<RequestId:{RequestId}, Type:{Type}>";
	}
}
