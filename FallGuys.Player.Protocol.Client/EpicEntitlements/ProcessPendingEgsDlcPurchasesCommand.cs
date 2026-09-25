using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.EpicEntitlements;

[ProtoContract(Name = "FallGuys_Player_ProcessPendingEgsDlcPurchasesCommand_V1")]
[Authorize(Roles = new string[] { "User" })]
public class ProcessPendingEgsDlcPurchasesCommand
{
}
