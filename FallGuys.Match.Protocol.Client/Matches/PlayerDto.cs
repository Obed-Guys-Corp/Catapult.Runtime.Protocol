using ProtoBuf;

namespace FallGuys.Match.Protocol.Client.Matches;

[ProtoContract(Name = "FallGuys_Match_PlayerDto_V1")]
public class PlayerDto
{
    [ProtoMember(1)]
    public string? AccountId { get; set; }

    [ProtoMember(2)]
    public string? PlatformId { get; set; }

    [ProtoMember(3)]
    public string? PlatformAccountId { get; set; }

    [ProtoMember(4)]
    public string? PlatformAccountName { get; set; }

    [ProtoMember(5)]
    public int ContentTargetingIndex { get; set; }

    [ProtoMember(6)]
    public InternalAccountNameDto? InternalAccountName { get; set; }

    [ProtoMember(7)]
    public int? SkillScore { get; set; }

    [ProtoMember(8)]
    public PlayerOptionsDto? PlayerOptionsDto { get; set; }
}
