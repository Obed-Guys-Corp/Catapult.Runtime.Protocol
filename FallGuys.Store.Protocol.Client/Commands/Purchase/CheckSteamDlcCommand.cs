using System;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[Obsolete("Please, use CheckSteamDlcAndRefundCommand")]
[ProtoContract(Name = "Catapult_Store_CheckSteamDlcCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class CheckSteamDlcCommand
{
}
