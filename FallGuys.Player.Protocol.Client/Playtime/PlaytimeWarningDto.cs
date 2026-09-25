using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Playtime;

[ProtoContract(Name = "FallGuys_Player_PlaytimeWarningDto_V1")]
public class PlaytimeWarningDto
{
    [ProtoMember(1)]
    public string MonitoringTierId { get; set; } = null!;
}
