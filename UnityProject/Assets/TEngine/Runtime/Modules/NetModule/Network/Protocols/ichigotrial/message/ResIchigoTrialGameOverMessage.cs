using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 通知前端一护试炼游戏结束 message
 */
public class ResIchigoTrialGameOverMessage : Message 
{
	//获得的奖励列表
	List<ItemInfo> _rewardList = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//获得的奖励列表
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
		//获得的奖励列表
		int _rewardList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardList_length; ++i) 
		{
			_rewardList.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * get 获得的奖励列表
	 * @return 
	 */
	public List<ItemInfo> GetRewardList()
	{
		return _rewardList;
	}
	
	/**
	 * set 获得的奖励列表
	 */
	public void SetRewardList(List<ItemInfo> rewardList)
	{
		_rewardList = rewardList;
	}
	
	
	public override int GetId() 
	{
		return 825115;
	}
}