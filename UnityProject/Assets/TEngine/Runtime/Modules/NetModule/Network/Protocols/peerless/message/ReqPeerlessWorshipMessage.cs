using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求膜拜 message
 */
public class ReqPeerlessWorshipMessage : Message 
{
	//期数
	int _time;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//期数
		SerializeUtils.WriteInt(stream, _time);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//期数
		_time = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 期数
	 */
	public int Time
	{
		set { _time = value; }
	    get { return _time; }
	}
	
	
	public override int GetId() 
	{
		return 817111;
	}
}