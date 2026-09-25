using Catapult.Protocol.Content;
using ProtoBuf;

namespace FallGuys.Client.Protocol.Cosmetics.Locker;

[ProtoContract(Name = "FG_Locker_CostumeDto_V1")]
public class CostumeDto
{
    [ProtoMember(1)]
    public ContentItemIdDto? Upper { get; set; }

    [ProtoMember(2)]
    public ContentItemIdDto? Lower { get; set; }

    [ProtoMember(3)]
    public ContentItemIdDto? Faceplate { get; set; }

    [ProtoMember(4)]
    public ContentItemIdDto? ColourScheme { get; set; }

    [ProtoMember(5)]
    public ContentItemIdDto? Pattern { get; set; }
}
