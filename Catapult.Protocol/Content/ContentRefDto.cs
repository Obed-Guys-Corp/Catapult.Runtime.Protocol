using ProtoBuf;

namespace Catapult.Protocol.Content;

[ProtoContract(Name = "Catapult_ContentRefDto_V1")]
public class ContentRefDto
{
    [ProtoMember(1)]
    public ContentGroupIdDto? GroupId { get; set; }

    [ProtoMember(2)]
    public ContentItemIdDto? ItemId { get; set; }
}
