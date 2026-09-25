using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_StoreBundleItemDto_V1")]
public class SymphonyStoreBundleItemDto
{
    [ProtoMember(1)]
    public string? ContentType { get; set; }

    [ProtoMember(2)]
    public string? ContentId { get; set; }

    [ProtoMember(3)]
    public int? Quantity { get; set; }

    [ProtoMember(4)]
    public bool? DoesPlayerOwnItem { get; set; }

    [ProtoMember(5)]
    public int? Cost { get; set; }

    [ProtoMember(6)]
    public string? CostumeSetId { get; set; }

    [ProtoMember(7)]
    public bool IsOwned { get; set; }
}
