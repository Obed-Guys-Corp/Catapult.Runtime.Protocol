using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Requests;

[ProtoContract(Name = "Catapult_Login_ForgetAccountRequest_V1")]
[Authorize(AllowAnonymous = true)]
public class ForgetAccountRequest
{
	private Dictionary<string, string>? _identityProperties;

	[ProtoMember(1)]
	public string? IdentityType { get; set; }

	[ProtoMember(2)]
	public string? IdentityToken { get; set; }

	[ProtoMember(3)]
	public Dictionary<string, string> IdentityProperties
	{
		get
		{
			return _identityProperties ?? (_identityProperties = new Dictionary<string, string>());
		}
		set
		{
			_identityProperties = value;
		}
	}
}
