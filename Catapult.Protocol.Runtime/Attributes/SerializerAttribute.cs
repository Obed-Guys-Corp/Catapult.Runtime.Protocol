namespace Catapult.Protocol.Runtime.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    internal class SerializerAttribute(Type serializer) : Attribute
    {
        public Type? Serializer { get; } = serializer;
    }
}
