using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Compensation;

[ProtoContract(Name = "FallGuys_AdminPlayerCompensationDto_V1")]
public class AdminPlayerCompensationDto
{
    [ProtoMember(1)]
    public List<PlayerContentHistoryDto>? ContentHistory { get; set; }
}
