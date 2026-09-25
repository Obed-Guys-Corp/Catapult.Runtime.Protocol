using System.Collections.Generic;
using ProtoBuf;

namespace Catapult.Modules.Items.Protocol.Dtos;

[ProtoContract(Name = "Catapult_Items_ItemAddResultDto_V1")]
public class ItemAddedDto
{
	[ProtoIgnore]
	private List<ItemChangedDto>? _changes;

	[ProtoMember(1)]
	public string? ContentId { get; set; }

	[ProtoMember(2)]
	public string? ContentType { get; set; }

	[ProtoMember(3)]
	public List<ItemChangedDto> Changes
	{
		get
		{
			return _changes ?? (_changes = new List<ItemChangedDto>());
		}
		set
		{
			_changes = value;
		}
	}
}
