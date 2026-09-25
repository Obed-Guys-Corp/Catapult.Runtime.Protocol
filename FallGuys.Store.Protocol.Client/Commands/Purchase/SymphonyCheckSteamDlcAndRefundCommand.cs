using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "Catapult_Store_SymphonyCheckSteamDlcAndRefundCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class SymphonyCheckSteamDlcAndRefundCommand
{
}
