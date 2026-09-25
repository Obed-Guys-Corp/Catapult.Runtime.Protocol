using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_PurchaseLineDto_V1")]
public class PurchaseLineDto
{
	[ProtoMember(1)]
	public string? Type { get; set; }

	[ProtoMember(2)]
	public string? Id { get; set; }
}
