using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一键交往 message
 */
public class ResFastDateGirlMessage : Message 
{
	//奖励列表
	List<MopReward> _reward = new List<MopReward>();
	//妹子交往后的新信息
	List<GirlInfo> _girlInfo = new List<GirlInfo>();
	//二段交往（有道具奖励）妹子Id列表
	List<int> _girlIdList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//奖励列表
		SerializeUtils.WriteShort(stream, (short)_reward.Count);

		foreach (var element in _reward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//妹子交往后的新信息
		SerializeUtils.WriteShort(stream, (short)_girlInfo.Count);

		foreach (var element in _girlInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//二段交往（有道具奖励）妹子Id列表
		SerializeUtils.WriteShort(stream, (short)_girlIdList.Count);

		foreach (var element in _girlIdList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//奖励列表
		int _reward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _reward_length; ++i) 
		{
			_reward.Add(SerializeUtils.ReadBean<MopReward>(stream));
		}
		//妹子交往后的新信息
		int _girlInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _girlInfo_length; ++i) 
		{
			_girlInfo.Add(SerializeUtils.ReadBean<GirlInfo>(stream));
		}
		//二段交往（有道具奖励）妹子Id列表
		int _girlIdList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _girlIdList_length; ++i) 
		{
			_girlIdList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 奖励列表
	 * @return 
	 */
	public List<MopReward> GetReward()
	{
		return _reward;
	}
	
	/**
	 * set 奖励列表
	 */
	public void SetReward(List<MopReward> reward)
	{
		_reward = reward;
	}
	
	/**
	 * get 妹子交往后的新信息
	 * @return 
	 */
	public List<GirlInfo> GetGirlInfo()
	{
		return _girlInfo;
	}
	
	/**
	 * set 妹子交往后的新信息
	 */
	public void SetGirlInfo(List<GirlInfo> girlInfo)
	{
		_girlInfo = girlInfo;
	}
	
	/**
	 * get 二段交往（有道具奖励）妹子Id列表
	 * @return 
	 */
	public List<int> GetGirlIdList()
	{
		return _girlIdList;
	}
	
	/**
	 * set 二段交往（有道具奖励）妹子Id列表
	 */
	public void SetGirlIdList(List<int> girlIdList)
	{
		_girlIdList = girlIdList;
	}
	
	
	public override int GetId() 
	{
		return 108210;
	}
}