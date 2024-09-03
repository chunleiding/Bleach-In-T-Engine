using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回番队 message
 */
public class ResGangInstanceFightRewardMessage : Message 
{
	//番队副本战斗百分比奖励
	List<ItemInfo> _percentPrize = new List<ItemInfo>();
	//番队副本战斗[贡献度,金钱,经验]奖励
	List<ItemInfo> _rewardPrize = new List<ItemInfo>();
	//最后击杀boss奖励
	List<ItemInfo> _lastKillBossPrize = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队副本战斗百分比奖励
		SerializeUtils.WriteShort(stream, (short)_percentPrize.Count);

		foreach (var element in _percentPrize)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//番队副本战斗[贡献度,金钱,经验]奖励
		SerializeUtils.WriteShort(stream, (short)_rewardPrize.Count);

		foreach (var element in _rewardPrize)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//最后击杀boss奖励
		SerializeUtils.WriteShort(stream, (short)_lastKillBossPrize.Count);

		foreach (var element in _lastKillBossPrize)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队副本战斗百分比奖励
		int _percentPrize_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _percentPrize_length; ++i) 
		{
			_percentPrize.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//番队副本战斗[贡献度,金钱,经验]奖励
		int _rewardPrize_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardPrize_length; ++i) 
		{
			_rewardPrize.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//最后击杀boss奖励
		int _lastKillBossPrize_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _lastKillBossPrize_length; ++i) 
		{
			_lastKillBossPrize.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * get 番队副本战斗百分比奖励
	 * @return 
	 */
	public List<ItemInfo> GetPercentPrize()
	{
		return _percentPrize;
	}
	
	/**
	 * set 番队副本战斗百分比奖励
	 */
	public void SetPercentPrize(List<ItemInfo> percentPrize)
	{
		_percentPrize = percentPrize;
	}
	
	/**
	 * get 番队副本战斗[贡献度,金钱,经验]奖励
	 * @return 
	 */
	public List<ItemInfo> GetRewardPrize()
	{
		return _rewardPrize;
	}
	
	/**
	 * set 番队副本战斗[贡献度,金钱,经验]奖励
	 */
	public void SetRewardPrize(List<ItemInfo> rewardPrize)
	{
		_rewardPrize = rewardPrize;
	}
	
	/**
	 * get 最后击杀boss奖励
	 * @return 
	 */
	public List<ItemInfo> GetLastKillBossPrize()
	{
		return _lastKillBossPrize;
	}
	
	/**
	 * set 最后击杀boss奖励
	 */
	public void SetLastKillBossPrize(List<ItemInfo> lastKillBossPrize)
	{
		_lastKillBossPrize = lastKillBossPrize;
	}
	
	
	public override int GetId() 
	{
		return 109131;
	}
}