using Catapult.Protocol;
using ProtoBuf;
using System;

namespace FallGuys.Client.Protocol.Cosmetics.Locker;

[ProtoContract(Name = "FG_Locker_StoreItemInLockerCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class StoreItemInLockerCommand
{
    [ProtoMember(1)]
    public Guid Index { get; set; }

    [ProtoMember(2)]
    public LockerItemType ItemType { get; set; }

    [ProtoMember(3)]
    public CostumeDto? Costume { get; set; }
}
