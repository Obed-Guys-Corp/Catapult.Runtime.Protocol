using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[ProtoContract(Name = "FallGuys_CosmeticsCollectionDto_V1")]
public class CosmeticsCollectionDto
{
    [ProtoMember(1)]
    public List<LowerCostumePieceDto> LowerCostumePieces { get; set; } = null!;

    [ProtoMember(2)]
    public List<UpperCostumePieceDto> UpperCostumePieces { get; set; } = null!;

    [ProtoMember(3)]
    public List<FaceplateDto> Faceplates { get; set; } = null!;

    [ProtoMember(4)]
    public List<ColourSchemeDto> ColourSchemes { get; set; } = null!;

    [ProtoMember(5)]
    public List<PatternDto> Patterns { get; set; } = null!;

    [ProtoMember(6)]
    public List<EmoteDto> Emotes { get; set; } = null!;

    [ProtoMember(7)]
    public List<PunchlineDto> Punchlines { get; set; } = null!;

    [ProtoMember(8)]
    public List<MonolithicCostumeDto> MonolithicCostumes { get; set; } = null!;

    [ProtoMember(9)]
    public List<NameplateDto> Nameplates { get; set; } = null!;

    [ProtoMember(10)]
    public List<NicknameDto> Nicknames { get; set; } = null!;

    [ProtoMember(11)]
    public List<PlinthDto> Plinths { get; set; } = null!;

    [ProtoMember(12)]
    public List<EmoticonDto> Emoticons { get; set; } = null!;

    [ProtoMember(13)]
    public List<PhraseDto> Phrases { get; set; } = null!;
}
