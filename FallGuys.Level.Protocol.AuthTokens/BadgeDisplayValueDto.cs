using Newtonsoft.Json;
using System;

namespace FallGuys.Level.Protocol.AuthTokens;

public class BadgeDisplayValueDto
{
    [JsonProperty("value")]
    public int Value { get; set; }

    [JsonProperty("lastUpdatedAt")]
    public DateTime? LastUpdatedAt { get; set; }
}
