using ProtoBuf;

namespace FallGuys.Store.Protocol.Client.Commands.Purchase;

[ProtoContract(Name = "Catapult_Store_SteamTransactionResult_V1")]
public class SteamTransactionResult
{
    [ProtoMember(1)]
    public ulong TransactionId { get; set; }

    [ProtoMember(2)]
    public ulong OrderId { get; set; }
}
