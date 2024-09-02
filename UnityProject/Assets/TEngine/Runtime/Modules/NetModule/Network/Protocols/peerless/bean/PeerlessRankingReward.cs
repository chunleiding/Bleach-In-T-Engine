using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 排名奖励列表
 */
public class PeerlessRankingReward : IMessageSerialize 
{
	//排名下限
	int _minRank;	
	//排名上限
	int _maxRank;	
	//普通奖励
	List<ItemInfo> _rewardItem = new List<ItemInfo>();
	//斩魄刀皮肤显示
	int _knifeSkinTime;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//排名下限
		SerializeUtils.WriteInt(stream, _minRank);
		//排名上限
		SerializeUtils.WriteInt(stream, _maxRank);
		//普通奖励
		SerializeUtils.WriteShort(stream, (short)_rewardItem.Count);

		foreach (var element in _rewardItem)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//斩魄刀皮肤显示
		SerializeUtils.WriteInt(stream, _knifeSkinTime);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//排名下限
		_minRank = SerializeUtils.ReadInt(stream);
		//排名上限
		_maxRank = SerializeUtils.ReadInt(stream);
		//普通奖励
		int _rewardItem_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardItem_length; ++i) 
		{
			_rewardItem.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//斩魄刀皮肤显示
		_knifeSkinTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 排名下限
	 */
	public int MinRank
	{
		set { _minRank = value; }
	    get { return _minRank; }
	}
	
	/**
	 * 排名上限
	 */
	public int MaxRank
	{
		set { _maxRank = value; }
	    get { return _maxRank; }
	}
	
	/**
	 * get 普通奖励
	 * @return 
	 */
	public List<ItemInfo> GetRewardItem()
	{
		return _rewardItem;
	}
	
	/**
	 * set 普通奖励
	 */
	public void SetRewardItem(List<ItemInfo> rewardItem)
	{
		_rewardItem = rewardItem;
	}
	
	/**
	 * 斩魄刀皮肤显示
	 */
	public int KnifeSkinTime
	{
		set { _knifeSkinTime = value; }
	    get { return _knifeSkinTime; }
	}
	
}