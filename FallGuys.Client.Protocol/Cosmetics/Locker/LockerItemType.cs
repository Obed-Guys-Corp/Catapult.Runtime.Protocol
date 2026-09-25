using ProtoBuf;

namespace FallGuys.Client.Protocol.Cosmetics.Locker;

[ProtoContract(Name = "FG_Locker_ItemType_V1")]
public enum LockerItemType
{
    [ProtoEnum(Name = "unknown")]
    Unknown,
    [ProtoEnum(Name = "costume")]
    Costume
}
