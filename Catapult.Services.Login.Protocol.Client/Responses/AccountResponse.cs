using ProtoBuf;
using System;
using System.Collections.Generic;

namespace Catapult.Services.Login.Protocol.Client.Responses;

[ProtoContract(Name = "Catapult_Login_AccountResponse_V1")]
public class AccountResponse
{
    [ProtoMember(1)]
    public string? Id { get; set; }

    [ProtoMember(2)]
    public List<string>? Roles { get; set; }

    [ProtoMember(3)]
    public DateTime Created { get; set; }

    [ProtoMember(4)]
    public bool IsBanned { get; set; }

    [ProtoMember(5)]
    public bool IsDeleted { get; set; }

    [ProtoMember(6)]
    public AccountDeletionReasonResponse? DeletionReason { get; set; }

    [ProtoMember(7)]
    public DateTime? DeletionDate { get; set; }

    [ProtoMember(8)]
    public int? Bucket { get; set; }

    [ProtoMember(9)]
    public bool ShouldLogRequests { get; set; }
}
