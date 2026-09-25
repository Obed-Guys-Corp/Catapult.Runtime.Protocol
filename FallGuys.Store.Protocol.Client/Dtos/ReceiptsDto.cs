using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_ReceiptsDto_V1")]
public class ReceiptsDto
{
    [ProtoMember(1)]
    public List<ReceiptRecordDto> Receipts { get; set; } = null!;
}
