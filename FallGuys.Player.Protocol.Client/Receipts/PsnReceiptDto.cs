using System;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Receipts;

[ProtoContract(Name = "FallGuys_Player_PsnReceiptDto_V1")]
public class PsnReceiptDto
{
	[ProtoMember(8)]
	public string Id { get; set; }

	[ProtoMember(1)]
	public string ItemId { get; set; }

	[ProtoMember(2)]
	public ulong UseCount { get; set; }

	[ProtoMember(3)]
	public string AccountId { get; set; }

	[ProtoMember(4)]
	public bool IsNonConsumable { get; set; }

	[ProtoMember(5)]
	public DateTime? PurchaseDate { get; set; }

	[ProtoMember(6)]
	public bool IsRefunded { get; set; }

	[ProtoMember(7)]
	public DateTime ProcessedAt { get; set; }
}
