using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步奖励信息 message
 */
public class ResRewardinfoSyncMessage : Message 
{
	//奖励列表
	List<WorldBossRewardItem> _rewardList = new List<WorldBossRewardItem>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//奖励列表
		SerializeUtils.WriteShort(stream, (short)_rewardList.Count);

		foreach (var element in _rewardList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//奖励列表
		int _rewardList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardList_length; ++i) 
		{
			_rewardList.Add(SerializeUtils.ReadBean<WorldBossRewardItem>(stream));
		}
	}
	
	/**
	 * get 奖励列表
	 * @return 
	 */
	public List<WorldBossRewardItem> GetRewardList()
	{
		return _rewardList;
	}
	
	/**
	 * set 奖励列表
	 */
	public void SetRewardList(List<WorldBossRewardItem> rewardList)
	{
		_rewardList = rewardList;
	}
	
	
	public override int GetId() 
	{
		return 807103;
	}
}