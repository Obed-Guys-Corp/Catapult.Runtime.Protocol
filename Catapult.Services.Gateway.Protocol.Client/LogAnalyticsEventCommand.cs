using System;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Gateway.Protocol.Client;

[Authorize(AllowAnonymous = true)]
[ProtoContract(Name = "Catapult_Gateway_LogAnalyticsEventCommand_V1")]
public class LogAnalyticsEventCommand
{
	[ProtoMember(1)]
	public string? EventType { get; set; }

	[ProtoMember(2)]
	public string? EventProperties { get; set; }

	[ProtoMember(3)]
	public string? AppVersion { get; set; }

	[ProtoMember(4)]
	public string? Platform { get; set; }

	[ProtoMember(5)]
	public int QueueDuration { get; set; }

	[ProtoMember(6)]
	public DateTime ClientTimeUtc { get; set; }

	[ProtoMember(7)]
	public DateTimeOffsetSurrogate? ClientTimeLocal { get; set; }

	[ProtoMember(8)]
	public string? EventId { get; set; }

	[ProtoMember(9)]
	public string? EventSource { get; set; }

	[ProtoMember(10)]
	public string? UserIdOverride { get; set; }

	[ProtoMember(11)]
	public string? Pipeline { get; set; }
}
