using ProtoBuf;

namespace FallGuys.Client.Protocol.Cosmetics.Locker;

[ProtoContract(Name = "FG_Locker_LockerDto_V1")]
public class LockerDto
{
    private LockerItemDto[]? _items;

    [ProtoMember(1)]
    public int MaxCountPerItemType { get; set; }

    [ProtoMember(2)]
    public LockerItemDto[] Items { get; set; }
}
