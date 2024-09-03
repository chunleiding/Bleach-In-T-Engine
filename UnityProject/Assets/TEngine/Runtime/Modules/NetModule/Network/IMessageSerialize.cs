using System.IO;

public interface IMessageSerialize
{
	/**
	 * 序列化
	 */
	void Serialize(Stream stream);
	/**
	 * 反序列化
	 */
	void Deserialize(Stream stream);
}

