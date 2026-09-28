using Catapult.Protocol.Runtime.Attributes;
using Catapult.Protocol.Runtime.Serializers.Core;
using FallGuys.Store.Protocol.Client.Dtos.Symphony;
using ProtoBuf;
using System.Collections;
using System.Reflection;
using static Catapult.Protocol.Runtime.Logger;

namespace Catapult.Protocol.Runtime.Serializers
{
    internal class BasicSerializer : ISerializer
    {
        public object Read(ProtoReader reader, Type msg)
        {
            object inst;
            if (msg is Type t)
                inst = Activator.CreateInstance(t)!;
            else
                inst = msg;

            int field;

            var attrs = inst!.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(x => x.GetCustomAttribute<ProtoMemberAttribute>() != null).ToDictionary(x => x.GetCustomAttribute<ProtoMemberAttribute>()!.Tag);
            
            while ((field = reader.ReadFieldHeader()) > 0)
            {
                if (RuntimeProtocol._knownMessages.TryGetValue((uint)field, out var msgType))
                {
                    Console.WriteLine(msgType);
                    var token = ProtoReader.StartSubItem(reader);
                    var nest = Read(reader, msgType);
                    ProtoReader.EndSubItem(token, reader);
                    inst = nest;
                    continue;
                }

                if (!attrs.TryGetValue(field, out var prop))
                {
                    LogLineWarn(GetType(), $"Property {field} lacks {nameof(ProtoMemberAttribute)}!!! Ensure all properties has correctly setted up {nameof(ProtoMemberAttribute)} in {inst.GetType().Name}. If you sure that attribute is set ensure that this is not a field");
                    reader.SkipField();
                    continue;
                }

                if (ReadValue(prop.PropertyType, out var res, reader))
                {
                    if (typeof(IList).IsAssignableFrom(prop.PropertyType) && prop.PropertyType.IsGenericType)
                    {
                        var currList = (IList?)prop.GetValue(inst);

                        if (currList == null)
                        {
                            currList = (IList)Activator.CreateInstance(prop.PropertyType)!;
                            prop.SetValue(inst, currList);
                        }

                        if (res is IList theList)
                        {
                            foreach (var item in theList)
                            {
                                currList.Add(item);
                            }
                        }
                    }
                    else if (typeof(IDictionary).IsAssignableFrom(prop.PropertyType) && prop.PropertyType.IsGenericType)
                    {
                        var currDict = (IDictionary?)prop.GetValue(inst);

                        if (currDict == null)
                        {
                            currDict = (IDictionary)Activator.CreateInstance(prop.PropertyType)!;
                            prop.SetValue(inst, currDict);
                        }

                        if (res is IDictionary theDict)
                        {
                            foreach (DictionaryEntry entry in theDict)
                            {
                                currDict[entry.Key] = entry.Value;
                            }
                        }
                    }
                    else
                    {
                        prop.SetValue(inst, res);
                    }
                }
                else
                    LogLineWarn(GetType(), $"Value of {prop.Name} remains null after reading, is this intended?");
            }

            return inst;
        }

        bool ReadValue(Type type, out object? res, ProtoReader reader)
        {
            res = null;

            LogLineDebug(GetType(), $"R: {type} - {Type.GetTypeCode(type)}");

            var ser = type.GetCustomAttribute<SerializerAttribute>();
            if (ser != null || type.GetCustomAttribute<ProtoContractAttribute>() != null)
            {
                var serializer = ser?.Serializer ?? typeof(BasicSerializer);

                var token = ProtoReader.StartSubItem(reader);
                res = SerializersInstances.Access(serializer).Read(reader, type);
                ProtoReader.EndSubItem(token, reader);
                return true;
            }

            var underlying = Nullable.GetUnderlyingType(type);
            var code = Type.GetTypeCode(underlying ?? type);

            switch (code)
            {
                case TypeCode.String:
                    res = reader.ReadString();
                    return true;
                case TypeCode.Boolean:
                    res = reader.ReadBoolean();
                    return true;
                case TypeCode.Int16:
                    res = reader.ReadInt16();
                    return true;
                case TypeCode.Int32:
                    res = reader.ReadInt32();
                    return true;
                case TypeCode.Int64:
                    res = reader.ReadInt64();
                    return true;
                case TypeCode.UInt16:
                    res = reader.ReadUInt16();
                    return true;
                case TypeCode.UInt32:
                    res = reader.ReadUInt32();
                    return true;
                case TypeCode.UInt64:
                    res = reader.ReadUInt64();
                    return true;
                case TypeCode.Single:
                    res = reader.ReadSingle();
                    return true;
                case TypeCode.Double:
                    res = reader.ReadDouble();
                    return true;
                case TypeCode.Byte:
                    res = reader.ReadByte();
                    return true;
                case TypeCode.SByte:
                    res = reader.ReadSByte();
                    return true;
                case TypeCode.DateTime:
                    res = BclHelpers.ReadDateTime(reader);
                    return true;
                case TypeCode.Decimal:
                    res = BclHelpers.ReadDecimal(reader);
                    return true;
                case TypeCode.Object:
                    if (type == typeof(Guid) || type == typeof(Guid?))
                    {
                        res = BclHelpers.ReadGuid(reader);
                        return true;
                    }

                    if (type.IsEnum)
                    {
                        res = Enum.ToObject(type, reader.ReadInt32());
                        return true;
                    }

                    if (type.IsArray)
                    {
                        var elemType = type.GetElementType()!;
                        var arrRes = new List<object?>();

                        int field;
                        while ((field = reader.ReadFieldHeader()) > 0)
                        {
                            if (ReadValue(elemType, out var item, reader))
                                arrRes.Add(item);
                        }

                        var arr = Array.CreateInstance(elemType, arrRes.Count);
                        for (int i = 0; i < arrRes.Count; i++)
                            arr.SetValue(arrRes[i], i);

                        res = arr;
                        return true;
                    }

                    if (type.IsGenericType)
                    {
                        var genTypeDef = type.GetGenericTypeDefinition();

                        if (genTypeDef == typeof(List<>) || genTypeDef == typeof(IEnumerable<>))
                        {
                            var itemType = type.GetGenericArguments()[0];

                            var listType = typeof(List<>).MakeGenericType(itemType);
                            var list = (IList)Activator.CreateInstance(listType)!;

                            if (ReadValue(itemType, out var item, reader))
                                list.Add(item);

                            res = list;
                            return true;
                        }

                        if (genTypeDef == typeof(Dictionary<,>))
                        {
                            var dict = (IDictionary)Activator.CreateInstance(type)!;
                            var args = type.GetGenericArguments();

                            int subField;
                            var token = ProtoReader.StartSubItem(reader);

                            object k = null!;
                            object v = null!;
                            while ((subField = reader.ReadFieldHeader()) > 0)
                            {
                                switch (subField)
                                {
                                    case 1:
                                        ReadValue(args[0], out k!, reader);
                                        break;
                                    case 2:
                                        ReadValue(args[1], out v!, reader);
                                        break;
                                }
                            }

                            ProtoReader.EndSubItem(token, reader);
                            dict.Add(k, v);
                            res = dict;
                            return true;
                        }
                    }

                    LogLineWarn(GetType(), $"Property of type \"{type}\" (reading as {TypeCode.Object}) IS NOT SUPPORTED!!! Implement custom {nameof(ISerializer)} for this message to read this property.");
                    reader.SkipField();
                    break;
                default:
                    LogLineWarn(GetType(), $"Property of type \"{type}\" (reading as {Type.GetTypeCode(type)}) IS NOT SUPPORTED!!! Implement custom {nameof(ISerializer)} for this message to read this property.");
                    reader.SkipField();
                    break;
            }

            return false;
        }

        public void Write(object body, ProtoWriter writer)
        {
            var attrs = body!.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(x => x.GetCustomAttribute<ProtoMemberAttribute>() != null).OrderBy(x => x.GetCustomAttribute<ProtoMemberAttribute>()!.Tag);
            foreach (var prop in attrs)
            {
                var val = prop.GetValue(body, null);
                if (val == null) continue;

                WriteValue(prop.PropertyType, val, prop.GetCustomAttribute<ProtoMemberAttribute>()!.Tag, writer);
            }
        }

        private void WriteValue(Type type, object val, int tag, ProtoWriter writer)
        {
            if (val == null) return;

            LogLineDebug(GetType(), $"W: {type} - {tag} {Type.GetTypeCode(type)}");

            var intefaces = type.GetInterfaces();
            var ser = intefaces.Select(x => x.GetCustomAttribute<SerializerAttribute>()).FirstOrDefault(x => x != null) ?? type.GetCustomAttribute<SerializerAttribute>();

            if (ser != null || type.GetCustomAttribute<ProtoContractAttribute>() != null)
            {
                var serializer = ser?.Serializer ?? typeof(BasicSerializer);

                ProtoWriter.WriteFieldHeader(tag, WireType.String, writer);
                var token = ProtoWriter.StartSubItem(null, writer);
                SerializersInstances.Access(serializer).Write(val, writer);
                ProtoWriter.EndSubItem(token, writer);
                return;
            }

            var underlying = Nullable.GetUnderlyingType(type);
            var code = Type.GetTypeCode(underlying ?? type);

            switch (code)
            {
                case TypeCode.String:
                    ProtoWriter.WriteFieldHeader(tag, WireType.String, writer);
                    ProtoWriter.WriteString((string)val, writer);
                    return;
                case TypeCode.Int16:
                    ProtoWriter.WriteFieldHeader(tag, WireType.Variant, writer);
                    ProtoWriter.WriteInt16((short)val, writer);
                    return;
                case TypeCode.Int32:
                    ProtoWriter.WriteFieldHeader(tag, WireType.Variant, writer);
                    ProtoWriter.WriteInt32((int)val, writer);
                    return;
                case TypeCode.Int64:
                    ProtoWriter.WriteFieldHeader(tag, WireType.Variant, writer);
                    ProtoWriter.WriteInt64((long)val, writer);
                    return;
                case TypeCode.UInt16:
                    ProtoWriter.WriteFieldHeader(tag, WireType.Variant, writer);
                    ProtoWriter.WriteUInt16((ushort)val, writer);
                    return;
                case TypeCode.UInt32:
                    ProtoWriter.WriteFieldHeader(tag, WireType.Variant, writer);
                    ProtoWriter.WriteUInt32((uint)val, writer);
                    return;
                case TypeCode.UInt64:
                    ProtoWriter.WriteFieldHeader(tag, WireType.Variant, writer);
                    ProtoWriter.WriteUInt64((ulong)val, writer);
                    return;
                case TypeCode.Boolean:
                    ProtoWriter.WriteFieldHeader(tag, WireType.Variant, writer);
                    ProtoWriter.WriteBoolean((bool)val, writer);
                    return;
                case TypeCode.Double:
                    ProtoWriter.WriteFieldHeader(tag, WireType.Fixed64, writer);
                    ProtoWriter.WriteDouble((double)val, writer);
                    return;
                case TypeCode.Single:
                    ProtoWriter.WriteFieldHeader(tag, WireType.Fixed32, writer);
                    ProtoWriter.WriteSingle((float)val, writer);
                    return;
                case TypeCode.DateTime:
                    ProtoWriter.WriteFieldHeader(tag, WireType.String, writer);
                    BclHelpers.WriteDateTime((DateTime)val, writer);
                    return;
                case TypeCode.Object:
                    if (type.IsEnum)
                    {
                        ProtoWriter.WriteFieldHeader(tag, WireType.Variant, writer);
                        ProtoWriter.WriteInt32((int)val, writer);
                        return;
                    }

                    if (type == typeof(Guid) || type == typeof(Guid?))
                    {
                        ProtoWriter.WriteFieldHeader(tag, WireType.String, writer);
                        BclHelpers.WriteGuid((Guid)val, writer);
                        return;
                    }

                    if (type.IsEnum)
                    {
                        ProtoWriter.WriteFieldHeader(tag, WireType.Variant, writer);
                        ProtoWriter.WriteInt32((int)val, writer);
                        return;
                    }

                    if (type.IsArray)
                    {
                        var arr = (Array)val;
                        var elemType = type.GetElementType()!;
                        foreach (var item in arr)
                        {
                            if (item == null) continue;
                            WriteValue(elemType, item, tag, writer);
                        }
                        return;
                    }

                    if (type.IsGenericType)
                    {
                        var gdef = type.GetGenericTypeDefinition();

                        if (gdef == typeof(List<>))
                        {
                            var list = (IList)val;
                            var itemType = type.GetGenericArguments()[0];
                            foreach (var item in list)
                            {
                                if (item == null) continue;
                                WriteValue(itemType, item, tag, writer);
                            }
                            return;
                        }

                        if (gdef == typeof(Dictionary<,>))
                        {
                            var dict = (IDictionary)val;
                            var args = type.GetGenericArguments();

                            foreach (DictionaryEntry etr in dict)
                            {
                                ProtoWriter.WriteFieldHeader(tag, WireType.String, writer);
                                var token = ProtoWriter.StartSubItem(null, writer);

                                if (etr.Key != null)
                                    WriteValue(args[0], etr.Key, 1, writer);

                                if (etr.Value != null)
                                    WriteValue(args[1], etr.Value, 2, writer);

                                ProtoWriter.EndSubItem(token, writer);
                            }
                            return;
                        }
                    }
                    return;
            }
        }

    }
}
