using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 排行榜奖励配置
 */
public class RankingReward : IMessageSerialize 
{
	//奖励道具列表
	List<ItemInfo> _Reward = new List<ItemInfo>();
	//名次区间
	List<int> _Level = new List<int>();
	//标签描述
	string _Tag;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//奖励道具列表
		SerializeUtils.WriteShort(stream, (short)_Reward.Count);

		foreach (var element in _Reward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//名次区间
		SerializeUtils.WriteShort(stream, (short)_Level.Count);

		foreach (var element in _Level)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//标签描述
		SerializeUtils.WriteString(stream, _Tag);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//奖励道具列表
		int _Reward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _Reward_length; ++i) 
		{
			_Reward.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//名次区间
		int _Level_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _Level_length; ++i) 
		{
			_Level.Add(SerializeUtils.ReadInt(stream));
		}
		//标签描述
		_Tag = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * get 奖励道具列表
	 * @return 
	 */
	public List<ItemInfo> GetReward()
	{
		return _Reward;
	}
	
	/**
	 * set 奖励道具列表
	 */
	public void SetReward(List<ItemInfo> Reward)
	{
		_Reward = Reward;
	}
	
	/**
	 * get 名次区间
	 * @return 
	 */
	public List<int> GetLevel()
	{
		return _Level;
	}
	
	/**
	 * set 名次区间
	 */
	public void SetLevel(List<int> Level)
	{
		_Level = Level;
	}
	
	/**
	 * 标签描述
	 */
	public string Tag
	{
		set { _Tag = value; }
	    get { return _Tag; }
	}
	
}