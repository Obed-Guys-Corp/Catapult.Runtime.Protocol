using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_SymphonyBundleItemDto_V1")]
public class SymphonyBundleItemDto
{
	[ProtoMember(1)]
	public string? ContentId { get; set; }

	[ProtoMember(2)]
	public string? ContentType { get; set; }

	[ProtoMember(3)]
	public bool? DoesPlayerOwnItem { get; set; }
}
