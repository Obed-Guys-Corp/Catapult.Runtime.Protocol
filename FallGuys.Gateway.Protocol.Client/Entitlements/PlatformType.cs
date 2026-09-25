using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Entitlements;

[ProtoContract(Name = "FallGuys_Gateway_PlatformType_V1")]
public enum PlatformType
{
	[ProtoEnum(Name = "unknown")]
	Unknown,
	[ProtoEnum(Name = "playstation")]
	Playstation,
	[ProtoEnum(Name = "xbox")]
	Xbox,
	[ProtoEnum(Name = "steam")]
	Steam,
	[ProtoEnum(Name = "nintendo")]
	Nintendo
}
