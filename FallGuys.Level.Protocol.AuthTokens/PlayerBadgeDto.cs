using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FallGuys.Level.Protocol.AuthTokens;

public class PlayerBadgeDto
{
    [JsonProperty("namePlate")]
    public string? NamePlate { get; set; }

    [JsonProperty("nickName")]
    public string? NickName { get; set; }

    [JsonProperty("names")]
    public IReadOnlyDictionary<string, string> Names { get; set; } = null!;

    [Obsolete("Use 'DisplayValues' instead")]
    [JsonProperty("displayValuesByType")]
    public IReadOnlyDictionary<string, int> DisplayValuesByType { get; set; } = null!;

    [Obsolete("Not needed")]
    [JsonProperty("preferredDisplayValueType")]
    public string? PreferredDisplayValueType { get; set; }

    [JsonProperty("displayValues")]
    public IReadOnlyDictionary<string, BadgeDisplayValueDto> DisplayValues { get; set; } = null!;
}
