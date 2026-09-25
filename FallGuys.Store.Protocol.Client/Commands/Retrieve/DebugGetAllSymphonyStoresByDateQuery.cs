using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;
using System;

namespace FallGuys.Store.Protocol.Client.Commands.Retrieve;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Store_GetAllSymphonyStoresByDateQuery_V1")]
[DebugMessage]
public class DebugGetAllSymphonyStoresByDateQuery
{
    [ProtoMember(1)]
    public DateTime AvailableAt { get; set; }
}
