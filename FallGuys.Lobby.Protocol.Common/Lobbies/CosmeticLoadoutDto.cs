using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Common.Lobbies;

[ProtoContract(Name = "FallGuys_Lobby_CosmeticLoadoutDto_V1")]
public class CosmeticLoadoutDto
{
    [ProtoMember(1)]
    public string UpperContentReference { get; set; } = null!;

    [ProtoMember(2)]
    public string LowerContentReference { get; set; } = null!;

    [ProtoMember(3)]
    public string FaceplateContentReference { get; set; } = null!;

    [ProtoMember(4)]
    public string ColourSchemeContentReference { get; set; } = null!;

    [ProtoMember(5)]
    public string PatternContentReference { get; set; } = null!;

    [ProtoMember(6)]
    public string PunchlineContentReference { get; set; } = null!;

    [ProtoMember(7)]
    public string MonolithicCostumeContentReference { get; set; } = null!;

    [ProtoMember(8)]
    public string NameplateContentReference { get; set; } = null!;

    [ProtoMember(9)]
    public string NicknameContentReference { get; set; } = null!;

    [ProtoMember(10)]
    public string PlinthContentReference { get; set; } = null!;
}
