using Newtonsoft.Json;
using System.Collections.Generic;

namespace FallGuys.Level.Protocol.AuthTokens;

public class PlaylistDto
{
    private IReadOnlyCollection<LevelMetadataDto>? _levels;

    [JsonProperty("type")]
    public PlaylistType Type { get; set; }

    [JsonProperty("id")]
    public string? Identifier { get; set; }

    [JsonProperty("levels")]
    public IReadOnlyCollection<LevelMetadataDto> Levels { get; set; }
}
