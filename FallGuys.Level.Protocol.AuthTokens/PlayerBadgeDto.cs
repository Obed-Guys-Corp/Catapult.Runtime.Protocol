using System.Collections.Generic;
using Newtonsoft.Json;

namespace FallGuys.Level.Protocol.AuthTokens;

public class PlayerBadgeDto
{
	private IReadOnlyDictionary<string, string>? _names;

	[JsonProperty("namePlate")]
	public string? NamePlate { get; set; }

	[JsonProperty("nickName")]
	public string? NickName { get; set; }

	[JsonProperty("names")]
	public IReadOnlyDictionary<string, string> Names
	{
		get
		{
			return _names ?? (_names = new Dictionary<string, string>());
		}
		set
		{
			_names = value;
		}
	}
}
