using ProtoBuf;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Catapult.Protocol;

[ProtoContract(Name = "Catapult_MessageBatch_V1")]
public class MessageBatch
{
	[ProtoIgnore]
	private List<Message>? _messages;

	[ProtoMember(1)]
	public List<Message> Messages
	{
		get => _messages ??= [];
		set => _messages = value;
	}

	public MessageBatch()
	{
		Messages = [];
	}

	public void AddRange(IEnumerable<Message> messages)
	{
		Messages.AddRange(messages);
	}

	public void Add<T>(T message) where T : Message
	{
		Messages.Add(message);
	}

	[return: MaybeNull]
	public TMessage Get<TMessage>() where TMessage : Message
	{
		foreach (Message message in Messages)
		{
			if (message is TMessage result)
			{
				return result;
			}
		}
		return null;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new();
		stringBuilder.AppendLine(GetType().Name);
		if (Messages.Count > 0)
		{
			for (int i = 0; i < Messages.Count; i++)
			{
				stringBuilder.AppendLine($"[{i}]: {Messages[i].GetTypeName()}");
			}
		}
		return stringBuilder.ToString();
	}
}
