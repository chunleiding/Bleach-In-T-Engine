using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步玩家操作方式 message
 */
public class ReqSyncPlayerControlModeMessage : Message 
{
	//0：划屏 1：摇杆
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：划屏 1：摇杆
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：划屏 1：摇杆
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：划屏 1：摇杆
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 105206;
	}
}