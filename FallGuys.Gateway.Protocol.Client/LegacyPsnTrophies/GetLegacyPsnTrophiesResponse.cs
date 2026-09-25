using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Gateway.Protocol.Client.LegacyPsnTrophies;

[ProtoContract(Name = "FallGuys_Gateway_GetLegacyPsnTrophiesResponse_V1")]
public class GetLegacyPsnTrophiesResponse
{
    [ProtoMember(1)]
    public List<LegacyPsnTrophyDto> LegacyPsnTrophies { get; set; }
}
