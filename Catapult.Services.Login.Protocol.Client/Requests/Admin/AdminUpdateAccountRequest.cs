using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Requests.Admin;

[ProtoContract(Name = "Catapult_Login_AdminUpdateAccountRequest_V1")]
[Authorize(Roles = new string[] { "Admin", "Super" })]
public class AdminUpdateAccountRequest
{
	private List<string>? _roles;

	[ProtoMember(1)]
	public string? AccountId { get; set; }

	[ProtoMember(2)]
	public bool IsBanned { get; set; }

	[ProtoMember(3)]
	public List<string> Roles
	{
		get
		{
			return _roles ?? (_roles = new List<string>());
		}
		set
		{
			_roles = value;
		}
	}

	[ProtoMember(4)]
	public bool ShouldLogRequests { get; set; }
}
