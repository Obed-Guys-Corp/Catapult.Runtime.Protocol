using System;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Receipts;

[ProtoContract(Name = "FallGuys_Player_AmazonEntitlementReceiptDto_V1")]
public class AmazonEntitlementReceiptDto
{
	[ProtoMember(1)]
	public string Id { get; set; }

	[ProtoMember(2)]
	public string EntitlementId { get; set; }

	[ProtoMember(3)]
	public string AccountId { get; set; }

	[ProtoMember(4)]
	public DateTime? PurchaseDate { get; set; }

	[ProtoMember(5)]
	public bool IsRefunded { get; set; }

	[ProtoMember(6)]
	public DateTime ProcessedAt { get; set; }
}
