using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FallGuys.Level.Protocol.AuthTokens;

public class PlayerBadgeDto
{
    [JsonIgnore]
    private IReadOnlyDictionary<string, string>? _names;

    [JsonIgnore]
    private IReadOnlyDictionary<string, int>? _displayValuesByType;
    private IReadOnlyDictionary<string, BadgeDisplayValueDto>? _displayValues;

    [JsonProperty("namePlate")]
    public string? NamePlate { get; set; }

    [JsonProperty("nickName")]
    public string? NickName { get; set; }

    [JsonProperty("names")]
    public IReadOnlyDictionary<string, string> Names { get; set; }

    [Obsolete("Use 'DisplayValues' instead")]
    [JsonProperty("displayValuesByType")]
    public IReadOnlyDictionary<string, int> DisplayValuesByType { get; set; }

    [Obsolete("Not needed")]
    [JsonProperty("preferredDisplayValueType")]
    public string? PreferredDisplayValueType { get; set; }

    [JsonProperty("displayValues")]
    public IReadOnlyDictionary<string, BadgeDisplayValueDto> DisplayValues { get; set; }
}
