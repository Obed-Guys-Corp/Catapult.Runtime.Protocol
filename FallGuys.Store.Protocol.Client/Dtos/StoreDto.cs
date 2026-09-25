using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_StoreDto_V2")]
public class StoreDto
{
	private List<StoreSectionDto>? _sections;

	[ProtoMember(2)]
	public string? Id { get; set; }

	[ProtoMember(1)]
	public List<StoreSectionDto> Sections
	{
		get
		{
			return _sections ?? (_sections = new List<StoreSectionDto>());
		}
		set
		{
			_sections = value;
		}
	}
}
