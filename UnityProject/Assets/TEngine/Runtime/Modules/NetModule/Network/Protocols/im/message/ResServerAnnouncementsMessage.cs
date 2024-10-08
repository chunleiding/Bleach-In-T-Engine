using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 服务器登录时发送的公告 message
 */
public class ResServerAnnouncementsMessage : Message 
{
	//公告内容
	List<string> _contents = new List<string>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//公告内容
		SerializeUtils.WriteShort(stream, (short)_contents.Count);

		foreach (var element in _contents)  
		{
			SerializeUtils.WriteString(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//公告内容
		int _contents_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _contents_length; ++i) 
		{
			_contents.Add(SerializeUtils.ReadString(stream));
		}
	}
	
	/**
	 * get 公告内容
	 * @return 
	 */
	public List<string> GetContents()
	{
		return _contents;
	}
	
	/**
	 * set 公告内容
	 */
	public void SetContents(List<string> contents)
	{
		_contents = contents;
	}
	
	
	public override int GetId() 
	{
		return 307107;
	}
}