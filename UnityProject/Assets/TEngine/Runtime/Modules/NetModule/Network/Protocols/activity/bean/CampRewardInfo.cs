using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动奖励
 */
public class CampRewardInfo : IMessageSerialize 
{
	//奖励描述
	string _describe;	
	//奖励物品
	List<ItemInfo> _rewardItem = new List<ItemInfo>();
	//需要的道具
	List<ItemInfo> _needItem = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//奖励描述
		SerializeUtils.WriteString(stream, _describe);
		//奖励物品
		SerializeUtils.WriteShort(stream, (short)_rewardItem.Count);

		foreach (var element in _rewardItem)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//需要的道具
		SerializeUtils.WriteShort(stream, (short)_needItem.Count);

		foreach (var element in _needItem)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//奖励描述
		_describe = SerializeUtils.ReadString(stream);
		//奖励物品
		int _rewardItem_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardItem_length; ++i) 
		{
			_rewardItem.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//需要的道具
		int _needItem_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _needItem_length; ++i) 
		{
			_needItem.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * 奖励描述
	 */
	public string Describe
	{
		set { _describe = value; }
	    get { return _describe; }
	}
	
	/**
	 * get 奖励物品
	 * @return 
	 */
	public List<ItemInfo> GetRewardItem()
	{
		return _rewardItem;
	}
	
	/**
	 * set 奖励物品
	 */
	public void SetRewardItem(List<ItemInfo> rewardItem)
	{
		_rewardItem = rewardItem;
	}
	
	/**
	 * get 需要的道具
	 * @return 
	 */
	public List<ItemInfo> GetNeedItem()
	{
		return _needItem;
	}
	
	/**
	 * set 需要的道具
	 */
	public void SetNeedItem(List<ItemInfo> needItem)
	{
		_needItem = needItem;
	}
	
}