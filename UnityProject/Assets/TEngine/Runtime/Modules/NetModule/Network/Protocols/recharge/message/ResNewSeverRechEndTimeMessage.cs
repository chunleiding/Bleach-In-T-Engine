using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 剩余时间消息上线发 message
 */
public class ResNewSeverRechEndTimeMessage : Message 
{
	//剩余时间
	int _restTiem;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//剩余时间
		SerializeUtils.WriteInt(stream, _restTiem);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//剩余时间
		_restTiem = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 剩余时间
	 */
	public int RestTiem
	{
		set { _restTiem = value; }
	    get { return _restTiem; }
	}
	
	
	public override int GetId() 
	{
		return 312210;
	}
}