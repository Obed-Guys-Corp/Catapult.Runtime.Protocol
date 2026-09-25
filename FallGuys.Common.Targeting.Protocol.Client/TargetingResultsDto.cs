using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Common.Targeting.Protocol.Client;

[ProtoContract(Name = "FallGuys_Player_TargetingResultsDto_V1")]
public class TargetingResultsDto
{
	[ProtoIgnore]
	private List<TargetingResultDto>? _resolvedTargets;

	[ProtoMember(1)]
	public List<TargetingResultDto> TargetingResults
	{
		get
		{
			return _resolvedTargets ?? (_resolvedTargets = new List<TargetingResultDto>());
		}
		set
		{
			_resolvedTargets = value;
		}
	}
}
