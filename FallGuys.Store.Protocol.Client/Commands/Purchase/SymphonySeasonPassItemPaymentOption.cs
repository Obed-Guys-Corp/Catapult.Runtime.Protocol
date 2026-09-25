using System;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "FallGuys_Store_SymphonySeasonPassItemPaymentOption_V1")]
public class SymphonySeasonPassItemPaymentOption : PaymentOption
{
	[ProtoMember(1)]
	public string? StoreId { get; set; }

	[ProtoMember(2)]
	public string? SectionId { get; set; }

	[ProtoMember(3)]
	public string? StorefrontId { get; set; }

	[ProtoMember(4)]
	public string? BundleSlotId { get; set; }

	[ProtoMember(5)]
	public string? BundleId { get; set; }

	[ProtoMember(6)]
	public int Option { get; set; }

	[ProtoMember(7)]
	[Obsolete("Use Line instead")]
	public ItemPaymentLine[]? Lines { get; set; }

	[ProtoMember(8)]
	public ItemPaymentLine? Line { get; set; }

	public override int GetOptionOrDefault()
	{
		return Option;
	}
}
