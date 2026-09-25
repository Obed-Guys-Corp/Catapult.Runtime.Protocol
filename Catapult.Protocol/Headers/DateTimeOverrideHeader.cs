using ProtoBuf;

namespace Catapult.Protocol.Headers;

[ProtoContract(Name = "Catapult_DateTimeOverrideHeader_V1")]
public class DateTimeOverrideHeader : MessageHeader
{
	[ProtoMember(1)]
	public TimeSpan Offset { get; set; }

	[ProtoMember(2)]
	public DateTime AbsoluteDateTimeUtc { get; set; }

	public DateTimeOverrideHeader(TimeSpan requestTimeOffset)
	{
		Offset = requestTimeOffset;
	}

	public DateTimeOverrideHeader(DateTime absoluteDateTimeUtc)
	{
		AbsoluteDateTimeUtc = absoluteDateTimeUtc;
	}

	public DateTimeOverrideHeader()
	{
	}

	public override string ToString()
	{
		return $"DateTimeOverrideHeader<Offset:{Offset}, AbsoluteDateTimeUtc:{AbsoluteDateTimeUtc}>";
	}
}
