using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 扫荡奖励
 */
public class MopReward : IMessageSerialize 
{
	//奖励列表
	List<ItemInfo> _rewardInfo = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//奖励列表
		SerializeUtils.WriteShort(stream, (short)_rewardInfo.Count);

		foreach (var element in _rewardInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//奖励列表
		int _rewardInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardInfo_length; ++i) 
		{
			_rewardInfo.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * get 奖励列表
	 * @return 
	 */
	public List<ItemInfo> GetRewardInfo()
	{
		return _rewardInfo;
	}
	
	/**
	 * set 奖励列表
	 */
	public void SetRewardInfo(List<ItemInfo> rewardInfo)
	{
		_rewardInfo = rewardInfo;
	}
	
}