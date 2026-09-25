using System;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_ReceiptRecordDto_V1")]
public class ReceiptRecordDto
{
	[ProtoMember(1)]
	public string? Id { get; set; }

	[ProtoMember(2)]
	public string? UserId { get; set; }

	[ProtoMember(3)]
	public DateTime TimeStamp { get; set; }

	[ProtoMember(4)]
	public byte[]? ReceiptData { get; set; }

	[ProtoMember(5)]
	public bool IsRefunded { get; set; }
}
