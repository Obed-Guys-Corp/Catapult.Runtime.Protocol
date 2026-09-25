using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_StoresDto_V1")]
public class SymphonyStoresDto
{
	private List<SymphonyStoreDto>? _stores;

	[ProtoMember(1)]
	public List<SymphonyStoreDto> Stores
	{
		get
		{
			return _stores ?? (_stores = new List<SymphonyStoreDto>());
		}
		set
		{
			_stores = value;
		}
	}
}
