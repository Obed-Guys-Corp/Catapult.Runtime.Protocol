using Catapult.Protocol.Runtime.Serializers;
using Catapult.Protocol.Runtime.Serializers.Core;

namespace Catapult.Protocol.Runtime.Attributes
{
    /// <summary>
    /// Marks a class of protobuf message to be using custom serializer instead of <see cref="BasicSerializer"/>
    /// </summary>
    /// <param name="serializer"></param>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class SerializerAttribute(Type serializer) : Attribute
    {
        /// <summary>
        /// Type of class that implements <see cref="ISerializer"/> interface.
        /// </summary>
        public Type? Serializer { get; } = serializer;
    }
}
