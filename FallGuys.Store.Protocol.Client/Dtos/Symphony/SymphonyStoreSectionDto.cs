using System;
using System.Collections.Generic;
using FallGuys.Common.Targeting.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_StoreSectionDto_V1")]
public class SymphonyStoreSectionDto
{
	private List<SymphonyStoreBundleDto>? _bundles;

	[ProtoMember(1)]
	public string? Id { get; set; }

	[ProtoMember(4)]
	public DateTime? NextRefreshAt { get; set; }

	[ProtoMember(5)]
	public List<SymphonyStoreBundleDto> Bundles
	{
		get
		{
			return _bundles ?? (_bundles = new List<SymphonyStoreBundleDto>());
		}
		set
		{
			_bundles = value;
		}
	}

	[ProtoMember(6)]
	public TargetingResultDto? TargetingResult { get; set; }
}
