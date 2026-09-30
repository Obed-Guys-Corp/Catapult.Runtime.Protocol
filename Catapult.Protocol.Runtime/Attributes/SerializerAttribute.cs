namespace Catapult.Protocol.Runtime.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class SerializerAttribute(Type serializer) : Attribute
    {
        public Type? Serializer { get; } = serializer;
    }
}
