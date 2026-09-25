using System.Collections.Generic;
using FallGuys.Store.Protocol.Client.Dtos.Symphony.PurchaseDtos;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_CostumeSetBundleDto_V1")]
public class CostumeSetBundleDto : SymphonyStoreBundleDto
{
	private IEnumerable<SymphonyStoreBundleItemDto>? _cosmetics;

	[ProtoMember(1)]
	public int Discount { get; set; }

	[ProtoMember(2)]
	public PurchaseDto? PurchaseOption { get; set; }

	[ProtoMember(3)]
	public IEnumerable<SymphonyStoreBundleItemDto> Cosmetics
	{
		get
		{
			return _cosmetics ?? (_cosmetics = new List<SymphonyStoreBundleItemDto>());
		}
		set
		{
			_cosmetics = value;
		}
	}
}
