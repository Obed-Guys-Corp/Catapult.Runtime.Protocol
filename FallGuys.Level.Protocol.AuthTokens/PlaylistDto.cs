using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FallGuys.Level.Protocol.AuthTokens;

public class PlaylistDto
{
	private IReadOnlyCollection<LevelMetadataDto>? _levels;

	[JsonProperty("type")]
	public PlaylistType Type { get; set; }

	[JsonProperty("id")]
	public string? Identifier { get; set; }

	[JsonProperty("levels")]
	public IReadOnlyCollection<LevelMetadataDto> Levels
	{
		get
		{
			return _levels ?? (_levels = (IReadOnlyCollection<LevelMetadataDto>?)(object)Array.Empty<LevelMetadataDto>());
		}
		set
		{
			_levels = value;
		}
	}
}
