using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 关卡和事件信息
 */
public class LevelEventInfo : IMessageSerialize 
{
	//关卡id
	int _levelId;	
	//事件描述id
	List<int> _eventDescribeId = new List<int>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//关卡id
		SerializeUtils.WriteInt(stream, _levelId);
		//事件描述id
		SerializeUtils.WriteShort(stream, (short)_eventDescribeId.Count);

		foreach (var element in _eventDescribeId)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//关卡id
		_levelId = SerializeUtils.ReadInt(stream);
		//事件描述id
		int _eventDescribeId_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _eventDescribeId_length; ++i) 
		{
			_eventDescribeId.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 关卡id
	 */
	public int LevelId
	{
		set { _levelId = value; }
	    get { return _levelId; }
	}
	
	/**
	 * get 事件描述id
	 * @return 
	 */
	public List<int> GetEventDescribeId()
	{
		return _eventDescribeId;
	}
	
	/**
	 * set 事件描述id
	 */
	public void SetEventDescribeId(List<int> eventDescribeId)
	{
		_eventDescribeId = eventDescribeId;
	}
	
}