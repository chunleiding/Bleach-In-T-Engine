using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复领奖结果(领奖失败时发送，成功不发送) message
 */
public class ResCampRewardResultExtendMessage : Message 
{
	//1:无活动数据，2:活动未开启，3:奖励已领取，4:领取次数已用完
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//1:无活动数据，2:活动未开启，3:奖励已领取，4:领取次数已用完
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//1:无活动数据，2:活动未开启，3:奖励已领取，4:领取次数已用完
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 1:无活动数据，2:活动未开启，3:奖励已领取，4:领取次数已用完
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 823110;
	}
}