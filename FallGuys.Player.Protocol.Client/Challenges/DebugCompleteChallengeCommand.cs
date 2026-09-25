using System;
using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges;

[ProtoContract(Name = "FallGuys_Player_DebugCompleteChallengeCommand_V1")]
[Authorize(Roles = new string[] { "User" })]
[Obsolete("Use DebugCompleteChallengeByIdCommand")]
[DebugMessage]
public class DebugCompleteChallengeCommand
{
	[ProtoMember(1)]
	public int Slot { get; set; }
}
