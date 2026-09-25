using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Requests;

[Authorize(AllowAnonymous = true)]
[ProtoContract(Name = "Catapult_Login_LoginRequest_V1")]
public class LoginRequest
{
	private Dictionary<string, string>? _properties;

	private Dictionary<string, string>? _userParameters;

	[ProtoMember(1)]
	public string? IdentityType { get; set; }

	[ProtoMember(2)]
	public string? IdentityToken { get; set; }

	[ProtoMember(3)]
	public string? ClientVersion { get; set; }

	[ProtoMember(4)]
	public string? ContentETag { get; set; }

	[ProtoMember(5)]
	public string? Platform { get; set; }

	[ProtoMember(6)]
	public Dictionary<string, string> UserParameters
	{
		get
		{
			return _userParameters ?? (_userParameters = new Dictionary<string, string>());
		}
		set
		{
			_userParameters = value;
		}
	}

	[ProtoMember(7)]
	public Dictionary<string, string> Properties
	{
		get
		{
			return _properties ?? (_properties = new Dictionary<string, string>());
		}
		set
		{
			_properties = value;
		}
	}

	[ProtoMember(8)]
	public string? ClientVersionSignature { get; set; }

	[ProtoMember(9)]
	public string? ContentBranch { get; set; }
}
