using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_ReceiptsDto_V1")]
public class ReceiptsDto
{
    private List<ReceiptRecordDto>? _receipts;

    [ProtoMember(1)]
    public List<ReceiptRecordDto> Receipts { get; set; }
}
