using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求活动奖励 message
 */
public class ReqCampRewardMessage : Message 
{
	//活动id
	int _campId;	
	//领奖次数
	int _times;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//活动id
		SerializeUtils.WriteInt(stream, _campId);
		//领奖次数
		SerializeUtils.WriteInt(stream, _times);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//活动id
		_campId = SerializeUtils.ReadInt(stream);
		//领奖次数
		_times = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 活动id
	 */
	public int CampId
	{
		set { _campId = value; }
	    get { return _campId; }
	}
	
	/**
	 * 领奖次数
	 */
	public int Times
	{
		set { _times = value; }
	    get { return _times; }
	}
	
	
	public override int GetId() 
	{
		return 311206;
	}
}