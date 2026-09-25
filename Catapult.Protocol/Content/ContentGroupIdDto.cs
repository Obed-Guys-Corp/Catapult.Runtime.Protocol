using ProtoBuf;

namespace Catapult.Protocol.Content;

[ProtoContract(Name = "Catapult_ContentGroupIdDto_V1")]
public class ContentGroupIdDto
{
    [ProtoMember(1)]
    public string? Value { get; set; }
}
