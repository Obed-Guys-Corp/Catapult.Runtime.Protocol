using System;
using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Entitlements;

[ProtoContract(Name = "FallGuys_Gateway_SyncEntitlementsForEpicCommand_V1")]
[Authorize(Roles = new string[] { "User" })]
public class SyncEntitlementsForEpicCommand : ISyncEntitlementsCommand
{
	[ProtoMember(1)]
	[Obsolete("Obsolete")]
	public string Puid { get; set; }

	[ProtoMember(2)]
	[Obsolete("Obsolete")]
	public List<EpicEntitlement> Entitlements { get; set; }

	[ProtoMember(3)]
	public string CurrencyCode { get; set; }

	[ProtoMember(4)]
	public string StoreId { get; set; }

	[ProtoMember(5)]
	public string StorefrontId { get; set; }

	[ProtoMember(6)]
	public string SectionId { get; set; }

	[ProtoMember(7)]
	public string IapId { get; set; }

	[ProtoMember(8)]
	public string StoreSessionId { get; set; }

	[ProtoMember(9)]
	public SyncPointType SyncPoint { get; set; }

	[ProtoMember(10)]
	public string CostDisplayLocal { get; set; }

	[ProtoMember(11)]
	public string CostUsd { get; set; }

	[ProtoMember(12)]
	public string CurrencyDisplayLocal { get; set; }

	[ProtoMember(13)]
	public string EntryPoint { get; set; }
}
