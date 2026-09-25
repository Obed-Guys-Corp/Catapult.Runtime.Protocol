using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Profile;

[ProtoContract(Name = "FallGuys_Player_PlayerNameLanguage_V1")]
public enum PlayerNameLanguage
{
	[ProtoEnum(Name = "unknown")]
	Unknown,
	[ProtoEnum(Name = "en")]
	En,
	[ProtoEnum(Name = "de")]
	De,
	[ProtoEnum(Name = "ru")]
	Ru,
	[ProtoEnum(Name = "es")]
	Es,
	[ProtoEnum(Name = "ko")]
	Ko,
	[ProtoEnum(Name = "zh")]
	Zh
}
