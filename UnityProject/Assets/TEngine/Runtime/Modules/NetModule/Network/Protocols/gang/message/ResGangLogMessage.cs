using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 新增番队日志 message
 */
public class ResGangLogMessage : Message 
{
	//事件信息
	GangEventInfo _eventInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//事件信息
		SerializeUtils.WriteBean(stream, _eventInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//事件信息
		_eventInfo = SerializeUtils.ReadBean<GangEventInfo>(stream);
	}
	
	/**
	 * 事件信息
	 */
	public GangEventInfo EventInfo
	{
		set { _eventInfo = value; }
	    get { return _eventInfo; }
	}
	
	
	public override int GetId() 
	{
		return 109104;
	}
}