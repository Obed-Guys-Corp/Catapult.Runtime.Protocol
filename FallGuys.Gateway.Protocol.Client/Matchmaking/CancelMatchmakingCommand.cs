using Catapult.Protocol;
using ProtoBuf;
using System;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking;

[Obsolete("Use the fn matchmaker")]
[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Gateway_CancelMatchmakingCommand_V1")]
public class CancelMatchmakingCommand
{
}
