using System;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking;

[Obsolete("Use the fn matchmaker")]
[ProtoContract(Name = "FallGuys_Gateway_CancelMatchmakingCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class CancelMatchmakingCommand
{
}
