using System;
using System.Linq;

namespace Catapult.Core.Extensions;

public static class AttributesExtensions
{
    public static bool ContainsAttribute<T>(this Type attributeProvider, bool inherit = true) where T : Attribute
    {
        return attributeProvider.GetCustomAttributes(typeof(T), inherit).Length == 1;
    }

    public static T? GetAttribute<T>(this Type attributeProvider, bool inherit = true) where T : Attribute
    {
        return attributeProvider.GetCustomAttributes(typeof(T), inherit).FirstOrDefault() as T;
    }
}
