using ProtoBuf;
using System.Collections.Generic;

namespace Catapult.Services.Login.Protocol.Client.Responses;

[ProtoContract(Name = "Catapult_Login_AccountsResponse_V1")]
public class AccountsResponse
{
    private List<AccountResponse>? _accounts;

    [ProtoMember(1)]
    public List<AccountResponse> Accounts { get; set; }

    [ProtoMember(2)]
    public int Total { get; set; }
}
