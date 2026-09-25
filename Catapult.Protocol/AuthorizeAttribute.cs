using System;

namespace Catapult.Protocol;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
public class AuthorizeAttribute : Attribute
{
	public bool AllowAnonymous { get; set; }

	public string[] Roles { get; set; }

	public AuthorizeAttribute()
	{
		Roles = [];
	}
}
