using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家对应奖励基数
 */
public class EscortRewardBase : IMessageSerialize 
{
	//对应系统
	int _system;	
	//奖励物品id
	int _rewardId;	
	//奖励数量
	int _rewardNum;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//对应系统
		SerializeUtils.WriteInt(stream, _system);
		//奖励物品id
		SerializeUtils.WriteInt(stream, _rewardId);
		//奖励数量
		SerializeUtils.WriteInt(stream, _rewardNum);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//对应系统
		_system = SerializeUtils.ReadInt(stream);
		//奖励物品id
		_rewardId = SerializeUtils.ReadInt(stream);
		//奖励数量
		_rewardNum = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 对应系统
	 */
	public int System
	{
		set { _system = value; }
	    get { return _system; }
	}
	
	/**
	 * 奖励物品id
	 */
	public int RewardId
	{
		set { _rewardId = value; }
	    get { return _rewardId; }
	}
	
	/**
	 * 奖励数量
	 */
	public int RewardNum
	{
		set { _rewardNum = value; }
	    get { return _rewardNum; }
	}
	
}