using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Responses;

[ProtoContract(Name = "Catapult_Login_SessionTokenResponse_V1")]
public class SessionTokenResponse
{
	private Dictionary<string, string>? _extraIdentities;

	private string[]? _roles;

	[ProtoMember(1)]
	public string? SessionToken { get; set; }

	[ProtoMember(2)]
	public string? AccountId { get; set; }

	[Obsolete("AnalyticsId found in `ExtraIdentities`.")]
	[ProtoMember(7)]
	public string? AnalyticsId { get; set; }

	[ProtoMember(8)]
	public Dictionary<string, string> ExtraIdentities
	{
		get
		{
			return _extraIdentities ?? (_extraIdentities = new Dictionary<string, string>());
		}
		set
		{
			_extraIdentities = value;
		}
	}

	[ProtoMember(3)]
	public string[] Roles
	{
		get
		{
			return _roles ?? (_roles = Array.Empty<string>());
		}
		set
		{
			_roles = value;
		}
	}

	[ProtoMember(4)]
	public string? ContentUrl { get; set; }

	[ProtoMember(5)]
	public string? ContentVersion { get; set; }

	[ProtoMember(6)]
	public string? ContentEtag { get; set; }
}
