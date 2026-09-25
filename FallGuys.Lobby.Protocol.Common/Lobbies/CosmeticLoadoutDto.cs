using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Common.Lobbies;

[ProtoContract(Name = "FallGuys_Lobby_CosmeticLoadoutDto_V1")]
public class CosmeticLoadoutDto
{
    [ProtoMember(1)]
    public string UpperContentReference { get; set; }

    [ProtoMember(2)]
    public string LowerContentReference { get; set; }

    [ProtoMember(3)]
    public string FaceplateContentReference { get; set; }

    [ProtoMember(4)]
    public string ColourSchemeContentReference { get; set; }

    [ProtoMember(5)]
    public string PatternContentReference { get; set; }

    [ProtoMember(6)]
    public string PunchlineContentReference { get; set; }

    [ProtoMember(7)]
    public string MonolithicCostumeContentReference { get; set; }

    [ProtoMember(8)]
    public string NameplateContentReference { get; set; }

    [ProtoMember(9)]
    public string NicknameContentReference { get; set; }

    [ProtoMember(10)]
    public string PlinthContentReference { get; set; }
}
