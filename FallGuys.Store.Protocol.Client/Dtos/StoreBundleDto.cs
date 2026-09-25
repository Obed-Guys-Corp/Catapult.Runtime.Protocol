using System;
using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_StoreBundleDto_V1")]
public class StoreBundleDto
{
	private List<PaymentDto>? _paymentOptions;

	[ProtoMember(1)]
	public string? Id { get; set; }

	[ProtoMember(2)]
	public List<PaymentDto> PaymentOptions
	{
		get
		{
			return _paymentOptions ?? (_paymentOptions = new List<PaymentDto>());
		}
		set
		{
			_paymentOptions = value;
		}
	}

	[ProtoMember(3)]
	public StoreBundleRewardDto? Reward { get; set; }

	[ProtoMember(4)]
	public string? CategoryName { get; set; }

	[ProtoMember(5)]
	public int? Stock { get; set; }

	[ProtoMember(6)]
	public DateTime? AvailableTo { get; set; }

	[ProtoMember(7)]
	public IapRegionPriceDto? IapRegionPrice { get; set; }
}
