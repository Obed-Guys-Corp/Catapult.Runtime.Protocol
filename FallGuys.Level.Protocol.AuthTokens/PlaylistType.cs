using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
