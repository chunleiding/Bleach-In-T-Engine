using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 服务器信息回复 message
 */
public class ResServerInfoMessage : Message 
{
	//现在距离开服时已经多少秒
	long _serverOpenTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//现在距离开服时已经多少秒
		SerializeUtils.WriteLong(stream, _serverOpenTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//现在距离开服时已经多少秒
		_serverOpenTime = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 现在距离开服时已经多少秒
	 */
	public long ServerOpenTime
	{
		set { _serverOpenTime = value; }
	    get { return _serverOpenTime; }
	}
	
	
	public override int GetId() 
	{
		return 100210;
	}
}