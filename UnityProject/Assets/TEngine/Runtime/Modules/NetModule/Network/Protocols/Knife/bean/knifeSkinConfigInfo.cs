using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 热更内容
 */
public class KnifeSkinConfigInfo : IMessageSerialize 
{
	//购买需要的阶级
	int _level;	
	//天数对应价格
	List<ItemInfo> _rewardItem = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//购买需要的阶级
		SerializeUtils.WriteInt(stream, _level);
		//天数对应价格
		SerializeUtils.WriteShort(stream, (short)_rewardItem.Count);

		foreach (var element in _rewardItem)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//购买需要的阶级
		_level = SerializeUtils.ReadInt(stream);
		//天数对应价格
		int _rewardItem_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardItem_length; ++i) 
		{
			_rewardItem.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * 购买需要的阶级
	 */
	public int Level
	{
		set { _level = value; }
	    get { return _level; }
	}
	
	/**
	 * get 天数对应价格
	 * @return 
	 */
	public List<ItemInfo> GetRewardItem()
	{
		return _rewardItem;
	}
	
	/**
	 * set 天数对应价格
	 */
	public void SetRewardItem(List<ItemInfo> rewardItem)
	{
		_rewardItem = rewardItem;
	}
	
}