using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 副本信息
 */
public class GangInstanceSelfInfo : IMessageSerialize 
{
	//副本id
	int _instanceId;	
	//今日挑战次数
	int _times;	
	//距离上次挑战结束时间剩余间隔(单位秒)
	int _challengeCD;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//副本id
		SerializeUtils.WriteInt(stream, _instanceId);
		//今日挑战次数
		SerializeUtils.WriteInt(stream, _times);
		//距离上次挑战结束时间剩余间隔(单位秒)
		SerializeUtils.WriteInt(stream, _challengeCD);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//副本id
		_instanceId = SerializeUtils.ReadInt(stream);
		//今日挑战次数
		_times = SerializeUtils.ReadInt(stream);
		//距离上次挑战结束时间剩余间隔(单位秒)
		_challengeCD = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 副本id
	 */
	public int InstanceId
	{
		set { _instanceId = value; }
	    get { return _instanceId; }
	}
	
	/**
	 * 今日挑战次数
	 */
	public int Times
	{
		set { _times = value; }
	    get { return _times; }
	}
	
	/**
	 * 距离上次挑战结束时间剩余间隔(单位秒)
	 */
	public int ChallengeCD
	{
		set { _challengeCD = value; }
	    get { return _challengeCD; }
	}
	
}