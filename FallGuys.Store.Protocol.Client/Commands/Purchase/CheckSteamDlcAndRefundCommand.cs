using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "Catapult_Store_CheckSteamDlcAndRefundCommand_V1")]
[Authorize(Roles = new string[] { "User" })]
public class CheckSteamDlcAndRefundCommand
{
}
