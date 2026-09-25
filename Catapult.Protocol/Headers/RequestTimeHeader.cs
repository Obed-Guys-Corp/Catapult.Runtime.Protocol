using ProtoBuf;

namespace Catapult.Protocol.Headers;

[ProtoContract(Name = "Catapult_RequestTimeHeader_V1")]
public class RequestTimeHeader : MessageHeader
{
	[ProtoMember(1)]
	public DateTime DateTimeUtc { get; set; }

	public RequestTimeHeader(DateTime requestTime)
	{
		DateTimeUtc = requestTime;
	}

	public RequestTimeHeader()
	{
	}

	public override string ToString()
	{
		return $"{nameof(RequestTimeHeader)}<DateTimeUtc:{DateTimeUtc}>";
	}
}
