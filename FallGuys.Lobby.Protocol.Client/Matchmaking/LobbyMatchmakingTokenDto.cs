using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Matchmaking;

[ProtoContract(Name = "Fg_Lobby_LobbyMatchmakingTokenDto")]
public class LobbyMatchmakingTokenDto
{
    [ProtoMember(1)]
    public string? Payload { get; set; }

    [ProtoMember(2)]
    public string? Signature { get; set; }

    [ProtoMember(3)]
    public string? ConnectionString { get; set; }

    [ProtoMember(4)]
    public string? MetaDataToken { get; set; }

    [ProtoMember(5)]
    public string? ServerEntryToken { get; set; }
}
