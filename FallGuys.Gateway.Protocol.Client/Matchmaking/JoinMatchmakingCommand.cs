using System;
using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking;

[Obsolete("Use fn matchmaker")]
[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Gateway_JoinMatchmakingCommand_V1")]
public class JoinMatchmakingCommand
{
	[ProtoMember(1)]
	public List<string> CompanionIdentities { get; set; }

	[ProtoMember(2)]
	public QosResultsDto QosResults { get; set; }

	[ProtoMember(3)]
	public string EntryCode { get; set; }

	[ProtoMember(4)]
	public List<string> ShowIds { get; set; }

	[ProtoMember(5)]
	public string RegionIdOverride { get; set; }

	[ProtoMember(6)]
	public bool CrossPlayEnabled { get; set; }

	[ProtoMember(7)]
	public string Profile { get; set; }
}
