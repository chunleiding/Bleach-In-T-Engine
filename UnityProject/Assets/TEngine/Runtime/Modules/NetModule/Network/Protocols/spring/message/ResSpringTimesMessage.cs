using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 进入温泉次数 message
 */
public class ResSpringTimesMessage : Message 
{
	//进入温泉次数
	int _times;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//进入温泉次数
		SerializeUtils.WriteInt(stream, _times);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//进入温泉次数
		_times = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 进入温泉次数
	 */
	public int Times
	{
		set { _times = value; }
	    get { return _times; }
	}
	
	
	public override int GetId() 
	{
		return 306102;
	}
}