using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Requests;

[Authorize(AllowAnonymous = true)]
[ProtoContract(Name = "Catapult_Login_AddIdentityRequest_V1")]
public class AddIdentityRequest
{
	private Dictionary<string, string>? _existingIdentityProperties;

	private Dictionary<string, string>? _newIdentityProperties;

	[ProtoMember(1)]
	public string? ExistingIdentityType { get; set; }

	[ProtoMember(2)]
	public string? ExistingIdentityToken { get; set; }

	[ProtoMember(3)]
	public Dictionary<string, string> ExistingIdentityProperties
	{
		get
		{
			return _existingIdentityProperties ?? (_existingIdentityProperties = new Dictionary<string, string>());
		}
		set
		{
			_existingIdentityProperties = value;
		}
	}

	[ProtoMember(4)]
	public string? NewIdentityType { get; set; }

	[ProtoMember(5)]
	public string? NewIdentityToken { get; set; }

	[ProtoMember(6)]
	public Dictionary<string, string> NewIdentityProperties
	{
		get
		{
			return _newIdentityProperties ?? (_newIdentityProperties = new Dictionary<string, string>());
		}
		set
		{
			_newIdentityProperties = value;
		}
	}
}
