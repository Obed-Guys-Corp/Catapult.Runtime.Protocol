using System;
using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Gateway_CreateGameEntryTokenCommand_V1")]
public class CreateGameEntryTokenCommand
{
	[ProtoMember(1)]
	public string ServerIp { get; set; }

	[ProtoMember(2)]
	public int ServerPort { get; set; }

	[ProtoMember(3)]
	public List<string> CompanionIdentities { get; set; }

	[Obsolete("This is not needed to directly connect to a game-server.")]
	[ProtoMember(4)]
	public QosResultsDto QosResults { get; set; }
}
