using ProtoBuf;

namespace Catapult.Services.Gateway.Protocol.Client;

[ProtoContract(Name = "Catapult_Gateway_ContentUpdateNotification_V1")]
public class ContentUpdateNotification
{
    [ProtoMember(1)]
    public string? ContentUrl { get; set; }

    [ProtoMember(2)]
    public string? ContentVersion { get; set; }

    [ProtoMember(3)]
    public bool ForceClientUpgrade { get; set; }

    [ProtoMember(4)]
    public string? ContentEtag { get; set; }
}
