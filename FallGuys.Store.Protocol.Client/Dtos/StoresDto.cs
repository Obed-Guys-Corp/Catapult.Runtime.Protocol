using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_StoresDto_V1")]
public class StoresDto
{
	private List<StoreDto>? _stores;

	[ProtoMember(1)]
	public List<StoreDto> Stores
	{
		get
		{
			return _stores ?? (_stores = new List<StoreDto>());
		}
		set
		{
			_stores = value;
		}
	}
}
