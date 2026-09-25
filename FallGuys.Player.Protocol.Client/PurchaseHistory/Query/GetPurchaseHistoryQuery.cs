using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.PurchaseHistory.Query;

[ProtoContract(Name = "FallGuys_GetPurchaseHistoryQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetPurchaseHistoryQuery
{
}
