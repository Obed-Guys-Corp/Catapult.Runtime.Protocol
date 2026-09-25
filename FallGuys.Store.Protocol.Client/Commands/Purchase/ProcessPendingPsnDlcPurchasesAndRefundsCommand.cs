using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "Catapult_Store_ProcessPendingPsnDlcPurchasesAndRefundsCommand_V1")]
public class ProcessPendingPsnDlcPurchasesAndRefundsCommand
{
    [ProtoMember(1)]
    public string? AuthCode { get; set; }

    [ProtoMember(2)]
    public ulong ServiceLabel { get; set; }

    [ProtoMember(3)]
    public int PsnEnvironment { get; set; }

    [ProtoMember(4)]
    public string? ProductId { get; set; }
}
