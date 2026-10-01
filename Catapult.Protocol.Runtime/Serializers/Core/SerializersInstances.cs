using System.Collections.Concurrent;

namespace Catapult.Runtime.Protocol.Serializers.Core
{
    internal static class SerializersInstances
    {
        static readonly ConcurrentDictionary<Type, ISerializer> CachedSerializers = [];

        internal static ISerializer Access(Type type)
        {
            if (CachedSerializers.TryGetValue(type, out var inst))
                return inst;

            inst = Activator.CreateInstance(type) as ISerializer;
            CachedSerializers.GetOrAdd(type, inst!);
            return inst!;
        }
    }
}
