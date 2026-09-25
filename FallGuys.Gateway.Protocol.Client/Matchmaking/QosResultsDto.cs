using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking;

[ProtoContract(Name = "FallGuys_Gateway_Matchmaking_QosResultsDto_V1")]
public class QosResultsDto
{
	[ProtoMember(1)]
	public List<QosResultDto> QoSResults { get; set; } = new List<QosResultDto>();
}
