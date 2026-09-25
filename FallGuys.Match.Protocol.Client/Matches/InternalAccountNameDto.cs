using ProtoBuf;

namespace FallGuys.Match.Protocol.Client.Matches;

[ProtoContract(Name = "FallGuys_Match_InternalAccountNameDto_V1")]
public class InternalAccountNameDto
{
	[ProtoMember(1)]
	public int? FirstSegmentIndex { get; set; }

	[ProtoMember(2)]
	public int? SecondSegmentIndex { get; set; }

	[ProtoMember(3)]
	public int? ThirdSegmentIndex { get; set; }

	[ProtoMember(4)]
	public int? Language { get; set; }
}
