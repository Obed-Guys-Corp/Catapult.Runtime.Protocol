using Catapult.Protocol;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking;

[ProtoContract(Name = "FallGuys_Gateway_CreateGameEntryTokenCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class CreateGameEntryTokenCommand
{
    [ProtoMember(1)]
    public string ServerIp { get; set; }

    [ProtoMember(2)]
    public int ServerPort { get; set; }

    [ProtoMember(3)]
    public List<string> CompanionIdentities { get; set; }

    [ProtoMember(4)]
    [Obsolete("This is not needed to directly connect to a game-server.")]
    public QosResultsDto QosResults { get; set; }
}
