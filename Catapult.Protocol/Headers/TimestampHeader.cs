using Catapult.Protocol.Custom.Attributes;
using Catapult.Protocol.Custom.Serializers;
using ProtoBuf;

namespace Catapult.Protocol.Headers;

[ProtoContract(Name = "Catapult_TimestampHeader_V1")]
public class TimestampHeader : MessageHeader
{
	[ProtoMember(1)]
	public DateTime Utc { get; set; }

	public override string ToString()
	{
		return $"{nameof(TimestampHeader)}<Utc:{Utc}>";
	}
}
