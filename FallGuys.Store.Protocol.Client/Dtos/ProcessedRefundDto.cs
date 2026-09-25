using System;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "FallGuys_Store_ProcessedRefundDto_V1")]
public class ProcessedRefundDto
{
	[ProtoMember(1)]
	public string? TransactionId { get; set; }

	[ProtoMember(2)]
	public string? Platform { get; set; }

	[ProtoMember(3)]
	public string? ProductContentReference { get; set; }

	[ProtoMember(4)]
	public DateTime RefundedDate { get; set; }

	[ProtoMember(5)]
	public DateTime PurchaseDate { get; set; }
}
