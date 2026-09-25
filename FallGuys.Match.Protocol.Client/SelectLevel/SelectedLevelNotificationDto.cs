using FallGuys.Client.Protocol.Rounds.RoundInfoDto;
using ProtoBuf;

namespace FallGuys.Match.Protocol.Client.SelectLevel;

[ProtoContract(Name = "FallGuys_Match_SelectedLevelNotificationDto_V1")]
public class SelectedLevelNotificationDto
{
    [ProtoMember(1)]
    public int NotificationIndex { get; set; }

    [ProtoMember(2)]
    public string? SessionId { get; set; }

    [ProtoMember(3)]
    public SelectedLevelDto? SelectedLevel { get; set; }

    [ProtoMember(4)]
    public int RoundIndex { get; set; }
}
