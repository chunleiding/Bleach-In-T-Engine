using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 排行榜奖励配置 message
 */
public class ResRankingRewardMessage : Message 
{
	//充值消耗排行榜奖励配置列表
	List<RankingReward> _rankingRewardList = new List<RankingReward>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//充值消耗排行榜奖励配置列表
		SerializeUtils.WriteShort(stream, (short)_rankingRewardList.Count);

		foreach (var element in _rankingRewardList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//充值消耗排行榜奖励配置列表
		int _rankingRewardList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rankingRewardList_length; ++i) 
		{
			_rankingRewardList.Add(SerializeUtils.ReadBean<RankingReward>(stream));
		}
	}
	
	/**
	 * get 充值消耗排行榜奖励配置列表
	 * @return 
	 */
	public List<RankingReward> GetRankingRewardList()
	{
		return _rankingRewardList;
	}
	
	/**
	 * set 充值消耗排行榜奖励配置列表
	 */
	public void SetRankingRewardList(List<RankingReward> rankingRewardList)
	{
		_rankingRewardList = rankingRewardList;
	}
	
	
	public override int GetId() 
	{
		return 819100;
	}
}