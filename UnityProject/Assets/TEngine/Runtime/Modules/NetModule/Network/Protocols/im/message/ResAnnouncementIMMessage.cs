using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端收到普通(非gm发送的)公告消息 message
 */
public class ResAnnouncementIMMessage : Message 
{
	//公告id
	int _announcementId;	
	//公告内容的参数
	List<string> _parameters = new List<string>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//公告id
		SerializeUtils.WriteInt(stream, _announcementId);
		//公告内容的参数
		SerializeUtils.WriteShort(stream, (short)_parameters.Count);

		foreach (var element in _parameters)  
		{
			SerializeUtils.WriteString(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//公告id
		_announcementId = SerializeUtils.ReadInt(stream);
		//公告内容的参数
		int _parameters_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _parameters_length; ++i) 
		{
			_parameters.Add(SerializeUtils.ReadString(stream));
		}
	}
	
	/**
	 * 公告id
	 */
	public int AnnouncementId
	{
		set { _announcementId = value; }
	    get { return _announcementId; }
	}
	
	/**
	 * get 公告内容的参数
	 * @return 
	 */
	public List<string> GetParameters()
	{
		return _parameters;
	}
	
	/**
	 * set 公告内容的参数
	 */
	public void SetParameters(List<string> parameters)
	{
		_parameters = parameters;
	}
	
	
	public override int GetId() 
	{
		return 307101;
	}
}