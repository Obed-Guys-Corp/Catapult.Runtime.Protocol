using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "Catapult_Store_SymphonyCheckSteamDlcAndRefundCommand_V1")]
public class SymphonyCheckSteamDlcAndRefundCommand
{
}
