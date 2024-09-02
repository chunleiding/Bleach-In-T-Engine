using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 喂食请求消息 message
 */
public class ReqFeedPetMessage : Message 
{
	//0 免费 1付费
	int _feedType;	
	//1 喂食 10 喂十次 -1 喂满
	int _feedTimes;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0 免费 1付费
		SerializeUtils.WriteInt(stream, _feedType);
		//1 喂食 10 喂十次 -1 喂满
		SerializeUtils.WriteInt(stream, _feedTimes);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0 免费 1付费
		_feedType = SerializeUtils.ReadInt(stream);
		//1 喂食 10 喂十次 -1 喂满
		_feedTimes = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0 免费 1付费
	 */
	public int FeedType
	{
		set { _feedType = value; }
	    get { return _feedType; }
	}
	
	/**
	 * 1 喂食 10 喂十次 -1 喂满
	 */
	public int FeedTimes
	{
		set { _feedTimes = value; }
	    get { return _feedTimes; }
	}
	
	
	public override int GetId() 
	{
		return 822103;
	}
}