using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "FallGuys_Store_IapRegionPriceDto_V1")]
public class IapRegionPriceDto
{
	[ProtoMember(1)]
	public string? CurrencyIsoCode { get; set; }

	[ProtoMember(2)]
	public float Amount { get; set; }
}
