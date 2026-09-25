using ProtoBuf;

namespace Catapult.Modules.Items.Protocol.Dtos;

[ProtoContract(Name = "Catapult_Items_ItemChange_Dto_V1")]
public class ItemChangedDto
{
	[ProtoMember(1)]
	public ItemDto? Item { get; set; }

	[ProtoMember(2)]
	public int DesiredQty { get; set; }

	[ProtoMember(3)]
	public int GivenQty { get; set; }

	[ProtoMember(4)]
	public int QtyAfterChange { get; set; }
}
