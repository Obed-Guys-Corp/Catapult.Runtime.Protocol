using ProtoBuf;

namespace Catapult.Protocol;

[ProtoContract(Name = "Catapult_UserContentTargeting_V1")]
public class ContentTargeting : IContentTargeting
{
    [ProtoIgnore]
    private string[]? _userSegments;

    public static ContentTargeting None => new();

    [ProtoMember(1)]
    public string? ContentVersion { get; set; }

    [ProtoMember(6)]
    public string? ContentBranch { get; set; }

    [ProtoMember(2)]
    public string? ClientVersion { get; set; }

    [ProtoMember(3)]
    public string? Platform { get; set; }

    [ProtoMember(4)]
    public string? ContentETag { get; set; }

    [ProtoMember(5)]
    public string[]? UserSegments
    {
        get => _userSegments ??= [];
        set => _userSegments = value;
    }

    public ContentTargeting(string? contentVersion, string? clientVersion, string? platform, string? contentETag, string[]? userSegments, string? contentBranch = null)
    {
        ContentVersion = contentVersion;
        ContentBranch = contentBranch;
        ClientVersion = clientVersion;
        Platform = platform;
        ContentETag = contentETag;
        UserSegments = userSegments!;
    }

    public ContentTargeting()
    {
    }
}
