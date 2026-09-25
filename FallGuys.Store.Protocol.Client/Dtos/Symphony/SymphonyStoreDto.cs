using FallGuys.Common.Targeting.Protocol.Client;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_StoreDto_V1")]
public class SymphonyStoreDto
{
	private List<SymphonyStorefrontDto>? _storefronts;

	[ProtoMember(1)]
	public string? Id { get; set; }

	[ProtoMember(2)]
	public List<SymphonyStorefrontDto> Storefronts
	{
		get
		{
			return _storefronts ?? (_storefronts = new List<SymphonyStorefrontDto>());
		}
		set
		{
			_storefronts = value;
		}
	}

	[ProtoMember(3)]
	public TargetingResultDto? TargetingResult { get; set; }
}
