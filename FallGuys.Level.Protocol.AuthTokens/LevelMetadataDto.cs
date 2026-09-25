using Newtonsoft.Json;
using System.Collections.Generic;

namespace FallGuys.Level.Protocol.AuthTokens;

public class LevelMetadataDto
{
    [JsonProperty("levelId")]
    public string? LevelId { get; set; }

    [JsonProperty("shareCode")]
    public string? ShareCode { get; set; }

    [JsonProperty("version")]
    public int Version { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("maxPlayersCount")]
    public int MaxPlayersCount { get; set; }

    [JsonProperty("imageUrl")]
    public string? ThumbnailImageUrl { get; set; }

    [JsonProperty("jsonUrl")]
    public string? LevelJsonUrl { get; set; }

    [JsonProperty("tags")]
    public IReadOnlyCollection<string> Tags { get; set; } = null!;

    [JsonProperty("playerBadge")]
    public PlayerBadgeDto? PlayerBadge { get; set; }

    [JsonProperty("platformId")]
    public string? PlatformId { get; set; }

    [JsonProperty("qualificationPercentage")]
    public int? QualificationPercentage { get; set; }

    [JsonProperty("config")]
    public string? Configuration { get; set; }

    [JsonProperty("isCompleted")]
    public bool? IsCompleted { get; set; }
}
