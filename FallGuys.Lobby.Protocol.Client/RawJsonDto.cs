using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client;

[ProtoContract(Name = "FallGuys_Lobby_Client_Read_RawJsonDto_V1")]
public class RawJsonDto
{
    [ProtoMember(1)]
    public string? Value { get; set; }
}
