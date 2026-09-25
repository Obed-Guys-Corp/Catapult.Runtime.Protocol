using Newtonsoft.Json;
using System.Collections.Generic;

namespace FallGuys.Level.Protocol.AuthTokens;

public class PlaylistDto
{
    [JsonProperty("type")]
    public PlaylistType Type { get; set; }

    [JsonProperty("id")]
    public string? Identifier { get; set; }

    [JsonProperty("levels")]
    public IReadOnlyCollection<LevelMetadataDto> Levels { get; set; } = null!;
}
