using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动更新
 */
public class CampUpdateTriggerExtend : IMessageSerialize 
{
	//活动id
	int _id;	
	//完成进度分子
	int _numerator;	
	//奖励状态（0：不可领奖，1达成，2已领奖）
	int _rewardState;	
	//已领奖次数
	int _rewardedTimes;	
	//剩余可领奖次数
	int _leftRewardTimes;	
	//扩展参数1
	string _ext1;	
	//扩展参数2
	string _ext2;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//活动id
		SerializeUtils.WriteInt(stream, _id);
		//完成进度分子
		SerializeUtils.WriteInt(stream, _numerator);
		//奖励状态（0：不可领奖，1达成，2已领奖）
		SerializeUtils.WriteInt(stream, _rewardState);
		//已领奖次数
		SerializeUtils.WriteInt(stream, _rewardedTimes);
		//剩余可领奖次数
		SerializeUtils.WriteInt(stream, _leftRewardTimes);
		//扩展参数1
		SerializeUtils.WriteString(stream, _ext1);
		//扩展参数2
		SerializeUtils.WriteString(stream, _ext2);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//活动id
		_id = SerializeUtils.ReadInt(stream);
		//完成进度分子
		_numerator = SerializeUtils.ReadInt(stream);
		//奖励状态（0：不可领奖，1达成，2已领奖）
		_rewardState = SerializeUtils.ReadInt(stream);
		//已领奖次数
		_rewardedTimes = SerializeUtils.ReadInt(stream);
		//剩余可领奖次数
		_leftRewardTimes = SerializeUtils.ReadInt(stream);
		//扩展参数1
		_ext1 = SerializeUtils.ReadString(stream);
		//扩展参数2
		_ext2 = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 活动id
	 */
	public int Id
	{
		set { _id = value; }
	    get { return _id; }
	}
	
	/**
	 * 完成进度分子
	 */
	public int Numerator
	{
		set { _numerator = value; }
	    get { return _numerator; }
	}
	
	/**
	 * 奖励状态（0：不可领奖，1达成，2已领奖）
	 */
	public int RewardState
	{
		set { _rewardState = value; }
	    get { return _rewardState; }
	}
	
	/**
	 * 已领奖次数
	 */
	public int RewardedTimes
	{
		set { _rewardedTimes = value; }
	    get { return _rewardedTimes; }
	}
	
	/**
	 * 剩余可领奖次数
	 */
	public int LeftRewardTimes
	{
		set { _leftRewardTimes = value; }
	    get { return _leftRewardTimes; }
	}
	
	/**
	 * 扩展参数1
	 */
	public string Ext1
	{
		set { _ext1 = value; }
	    get { return _ext1; }
	}
	
	/**
	 * 扩展参数2
	 */
	public string Ext2
	{
		set { _ext2 = value; }
	    get { return _ext2; }
	}
	
}