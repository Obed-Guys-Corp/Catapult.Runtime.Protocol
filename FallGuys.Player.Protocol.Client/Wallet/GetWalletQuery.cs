using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Wallet;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_GetWalletQuery_V1")]
public class GetWalletQuery
{
}
