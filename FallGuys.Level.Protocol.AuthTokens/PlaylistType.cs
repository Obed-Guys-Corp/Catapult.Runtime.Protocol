using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace FallGuys.Level.Protocol.AuthTokens;

[JsonConverter(typeof(StringEnumConverter))]
public enum PlaylistType
{
    [EnumMember(Value = "unknown")]
    Unknown,
    [EnumMember(Value = "level")]
    Level,
    [EnumMember(Value = "playlist")]
    Playlist
}
