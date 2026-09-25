using System;

namespace FallGuys.Common.Debug.Protocol.Client;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
public class DebugMessageAttribute : Attribute
{
}
