using Catapult.Protocol.Content;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.PurchaseHistory.Dto;

[ProtoContract(Name = "FallGuys_PurchaseHistory_PurchaseItemDto_V1")]
public class PurchasedItemDto
{
    [ProtoMember(1)]
    public ContentRefDto? ContentRef { get; set; }

    [ProtoMember(2)]
    public int Quantity { get; set; }
}
