using System;
using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Retrieve;

[Authorize(Roles = new string[] { "User" })]
[DebugMessage]
[ProtoContract(Name = "FallGuys_Store_GetAllSymphonyStoresByDateQuery_V1")]
public class DebugGetAllSymphonyStoresByDateQuery
{
	[ProtoMember(1)]
	public DateTime AvailableAt { get; set; }
}
