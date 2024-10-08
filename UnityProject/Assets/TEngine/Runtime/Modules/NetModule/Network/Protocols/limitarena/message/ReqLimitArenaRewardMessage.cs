using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求奖励 message
 */
public class ReqLimitArenaRewardMessage : Message 
{
	//领取第几次胜利次数的奖励
	int _rewardId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//领取第几次胜利次数的奖励
		SerializeUtils.WriteInt(stream, _rewardId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//领取第几次胜利次数的奖励
		_rewardId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 领取第几次胜利次数的奖励
	 */
	public int RewardId
	{
		set { _rewardId = value; }
	    get { return _rewardId; }
	}
	
	
	public override int GetId() 
	{
		return 502204;
	}
}