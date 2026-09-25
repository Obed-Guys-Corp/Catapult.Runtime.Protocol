using Catapult.Protocol.Headers;
using ProtoBuf;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace Catapult.Protocol;

[ProtoContract(Name = "Catapult_Message_V1")]
public class Message : IMessage
{
	[ProtoIgnore]
	private List<MessageHeader>? _headers;

	[ProtoMember(1)]
	public List<MessageHeader> Headers
    {
        get => _headers ??= [];
        set => _headers = value;
    }

    public void AttachHeader<THeader>(THeader? header) where THeader : MessageHeader
	{
		if (header != null)
		{
			RemoveHeader<THeader>();
			Headers.Add(header);
		}
	}

	[return: MaybeNull]
	public THeader GetHeader<THeader>() where THeader : IMessageHeader
	{
		foreach (MessageHeader header in Headers)
		{
			if (header is THeader)
			{
				return (THeader)(object)header;
			}
		}

		return default;
	}

	public bool TryGetHeader<T>([MaybeNullWhen(false)] out T header) where T : MessageHeader
	{
		header = GetHeader<T>();
		return header != null;
	}

	public void RemoveHeader<THeader>() where THeader : IMessageHeader
	{
		Headers.RemoveAll(x => x is THeader);
	}

	public void ClearHeaders()
	{
		Headers.Clear();
	}

	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.AppendLine(GetTypeName());

		if (Headers.Count > 0)
		{
			sb.AppendLine("Headers:");
			foreach (var header in Headers)
			{
				sb.AppendFormat(CultureInfo.InvariantCulture, "{0}:{1}\r\n", header.GetType().Name, header);
			}
		}

		return sb.ToString();
	}

	public virtual string GetTypeName()
	{
		return GetType().Name;
	}
}

[ProtoContract(Name = "Catapult_TMessage_V1")]
public class Message<TBody> : Message
{
	[ProtoMember(1)]
	[MaybeNull]
	public TBody Body;

	public Message(TBody body)
	{
		Body = body;
	}

	public Message()
	{
	}

	public override string GetTypeName()
	{
		if (Body == null) return "Message";
		return "Message<" + Body.GetType().Name + ">";
	}
}
