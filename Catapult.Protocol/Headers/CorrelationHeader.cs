using ProtoBuf;

namespace Catapult.Protocol.Headers;

[ProtoContract(Name = "Catapult_CorrelationHeader_V1")]
public class CorrelationHeader : MessageHeader
{
	[ProtoMember(1)]
	public Guid ActivityId { get; set; }

	public CorrelationHeader(Guid activityId)
	{
		ActivityId = activityId;
	}

	public CorrelationHeader()
	{
	}

	public override string ToString()
	{
		return $"CorrelationHeader<ActivityId:{ActivityId}>";
	}
}
