namespace Catapult.Protocol;

public interface IContentTargeting
{
    string? ContentVersion { get; }

    string? ContentBranch { get; }

    string? ClientVersion { get; }

    string? Platform { get; }

    string? ContentETag { get; }

    string[]? UserSegments { get; }
}
