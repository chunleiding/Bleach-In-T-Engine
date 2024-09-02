using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 奖励信息
 */
public class WorldBossRewardItem : IMessageSerialize 
{
	//开始排名
	int _minRank;	
	//结束排名
	int _maxRank;	
	//物品奖励信息
	List<ItemRewardInfo> _itemList = new List<ItemRewardInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//开始排名
		SerializeUtils.WriteInt(stream, _minRank);
		//结束排名
		SerializeUtils.WriteInt(stream, _maxRank);
		//物品奖励信息
		SerializeUtils.WriteShort(stream, (short)_itemList.Count);

		foreach (var element in _itemList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//开始排名
		_minRank = SerializeUtils.ReadInt(stream);
		//结束排名
		_maxRank = SerializeUtils.ReadInt(stream);
		//物品奖励信息
		int _itemList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _itemList_length; ++i) 
		{
			_itemList.Add(SerializeUtils.ReadBean<ItemRewardInfo>(stream));
		}
	}
	
	/**
	 * 开始排名
	 */
	public int MinRank
	{
		set { _minRank = value; }
	    get { return _minRank; }
	}
	
	/**
	 * 结束排名
	 */
	public int MaxRank
	{
		set { _maxRank = value; }
	    get { return _maxRank; }
	}
	
	/**
	 * get 物品奖励信息
	 * @return 
	 */
	public List<ItemRewardInfo> GetItemList()
	{
		return _itemList;
	}
	
	/**
	 * set 物品奖励信息
	 */
	public void SetItemList(List<ItemRewardInfo> itemList)
	{
		_itemList = itemList;
	}
	
}