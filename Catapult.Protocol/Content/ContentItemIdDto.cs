using ProtoBuf;

namespace Catapult.Protocol.Content;

[ProtoContract(Name = "Catapult_ContentItemIdDto_V1")]
public class ContentItemIdDto
{
    [ProtoMember(1)]
    public string? Value { get; set; }
}
