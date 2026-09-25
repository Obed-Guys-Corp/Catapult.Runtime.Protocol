using ProtoBuf;
using System;

namespace FallGuys.Client.Protocol.Cosmetics.Locker;

[ProtoContract(Name = "FG_Locker_LockerItemDto_V1")]
public class LockerItemDto
{
    [ProtoMember(1)]
    public Guid Id { get; set; }

    [ProtoMember(2)]
    public DateTime SavedAt { get; set; }

    [ProtoMember(3)]
    public LockerItemType ItemType { get; set; }

    [ProtoMember(4)]
    public CostumeDto? Costume { get; set; }
}
