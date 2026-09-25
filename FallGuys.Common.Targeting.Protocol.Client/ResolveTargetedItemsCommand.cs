using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Common.Targeting.Protocol.Client;

[ProtoContract(Name = "FallGuys_Player_ResolveTargetedItemsCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class ResolveTargetedItemsCommand
{
    [ProtoIgnore]
    private List<string>? _contentIds;

    [ProtoMember(1)]
    public List<string> ContentIds { get; set; }
}
