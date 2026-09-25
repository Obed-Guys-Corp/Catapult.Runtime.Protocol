using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rounds;

[ProtoContract(Name = "FallGuys_Player_Rounds_Performance_V1")]
public class PerformanceDto
{
    [ProtoMember(1)]
    public int? Position { get; set; }

    [ProtoMember(2)]
    public bool Qualified { get; set; }

    [ProtoMember(3)]
    public int? TeamPosition { get; set; }

    [ProtoMember(4)]
    public int? FinishedInPositionBracket { get; set; }
}
