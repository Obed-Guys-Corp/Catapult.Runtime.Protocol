using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Story_StoreBundleItemDto_V1")]
public class StoreBundleItemDto
{
    [ProtoMember(1)]
    public string? ContentType { get; set; }

    [ProtoMember(2)]
    public string? ContentId { get; set; }

    [ProtoMember(3)]
    public int Quantity { get; set; }
}
