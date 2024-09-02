using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队事件
 */
public class GangEventInfo : IMessageSerialize 
{
	//事件类型
	byte _eventType;	
	//事件参数值
	List<string> _eventParams = new List<string>();
	//事件时间
	long _eventTime;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//事件类型
		SerializeUtils.WriteByte(stream, _eventType);
		//事件参数值
		SerializeUtils.WriteShort(stream, (short)_eventParams.Count);

		foreach (var element in _eventParams)  
		{
			SerializeUtils.WriteString(stream, element);
		}
		//事件时间
		SerializeUtils.WriteLong(stream, _eventTime);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//事件类型
		_eventType = SerializeUtils.ReadByte(stream);
		//事件参数值
		int _eventParams_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _eventParams_length; ++i) 
		{
			_eventParams.Add(SerializeUtils.ReadString(stream));
		}
		//事件时间
		_eventTime = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 事件类型
	 */
	public byte EventType
	{
		set { _eventType = value; }
	    get { return _eventType; }
	}
	
	/**
	 * get 事件参数值
	 * @return 
	 */
	public List<string> GetEventParams()
	{
		return _eventParams;
	}
	
	/**
	 * set 事件参数值
	 */
	public void SetEventParams(List<string> eventParams)
	{
		_eventParams = eventParams;
	}
	
	/**
	 * 事件时间
	 */
	public long EventTime
	{
		set { _eventTime = value; }
	    get { return _eventTime; }
	}
	
}