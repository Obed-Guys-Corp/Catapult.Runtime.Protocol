using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_SeasonPassBundleDto_V1")]
public class SeasonPassBundleDto : SymphonyStoreBundleDto
{
	private List<SeasonPassOptionDto>? _options;

	[ProtoMember(1)]
	public List<SeasonPassOptionDto> Options
	{
		get
		{
			return _options ?? (_options = new List<SeasonPassOptionDto>());
		}
		set
		{
			_options = value;
		}
	}
}
