using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace Catapult.Services.Login.Protocol.Client.Requests;

[Authorize(AllowAnonymous = true)]
[ProtoContract(Name = "Catapult_Login_LoginRequest_V1")]
public class LoginRequest
{
    [ProtoMember(1)]
    public string? IdentityType { get; set; }

    [ProtoMember(2)]
    public string? IdentityToken { get; set; }

    [ProtoMember(3)]
    public string? ClientVersion { get; set; }

    [ProtoMember(4)]
    public string? ContentETag { get; set; }

    [ProtoMember(5)]
    public string? Platform { get; set; }

    [ProtoMember(6)]
    public Dictionary<string, string> UserParameters { get; set; } = null!;

    [ProtoMember(7)]
    public Dictionary<string, string> Properties { get; set; } = null!;

    [ProtoMember(8)]
    public string? ClientVersionSignature { get; set; }

    [ProtoMember(9)]
    public string? ContentBranch { get; set; }
}
