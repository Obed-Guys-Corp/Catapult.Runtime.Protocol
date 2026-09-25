using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Client.Protocol.ShowSelector.GetShowSelector;

[ProtoContract(Name = "FallGuys_ShowSelector_Get_Query_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetShowSelectorQuery
{
}
