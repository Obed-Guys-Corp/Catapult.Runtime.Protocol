using ProtoBuf;

namespace FallGuys.Client.Protocol.ShowSelector.GetShowSelector;

[ProtoContract(Name = "FallGuys_ShowSelector_Get_GateStatus_V1")]
public enum GateStatus
{
    [ProtoEnum(Name = "unlocked")]
    Unlocked,
    [ProtoEnum(Name = "locked")]
    Locked,
    [ProtoEnum(Name = "completed")]
    Completed
}
