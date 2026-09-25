using System.Collections.Generic;
using FallGuys.Common.Targeting.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_StorefrontDto_V1")]
public class SymphonyStorefrontDto
{
	private List<SymphonyStoreSectionDto>? _sections;

	[ProtoMember(1)]
	public string? Id { get; set; }

	[ProtoMember(2)]
	public List<SymphonyStoreSectionDto> Sections
	{
		get
		{
			return _sections ?? (_sections = new List<SymphonyStoreSectionDto>());
		}
		set
		{
			_sections = value;
		}
	}

	[ProtoMember(3)]
	public TargetingResultDto? TargetingResult { get; set; }
}
