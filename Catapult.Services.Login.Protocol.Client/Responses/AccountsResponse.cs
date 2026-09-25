using System.Collections.Generic;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Responses;

[ProtoContract(Name = "Catapult_Login_AccountsResponse_V1")]
public class AccountsResponse
{
	private List<AccountResponse>? _accounts;

	[ProtoMember(1)]
	public List<AccountResponse> Accounts
	{
		get
		{
			return _accounts ?? (_accounts = new List<AccountResponse>());
		}
		set
		{
			_accounts = value;
		}
	}

	[ProtoMember(2)]
	public int Total { get; set; }
}
