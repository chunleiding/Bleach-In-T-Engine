using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 资源更新奖励初始化 message
 */
public class ResResourceUpdateRewardInitMessage : Message 
{
	//0可领取，1已领取
	int _state;	
	//奖励物品
	List<ItemInfo> _rewardList = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0可领取，1已领取
		SerializeUtils.WriteInt(stream, _state);
		//奖励物品
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
		//0可领取，1已领取
		_state = SerializeUtils.ReadInt(stream);
		//奖励物品
		int _rewardList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardList_length; ++i) 
		{
			_rewardList.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * 0可领取，1已领取
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	/**
	 * get 奖励物品
	 * @return 
	 */
	public List<ItemInfo> GetRewardList()
	{
		return _rewardList;
	}
	
	/**
	 * set 奖励物品
	 */
	public void SetRewardList(List<ItemInfo> rewardList)
	{
		_rewardList = rewardList;
	}
	
	
	public override int GetId() 
	{
		return 803104;
	}
}