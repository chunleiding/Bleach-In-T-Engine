using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 排行榜模块信息
 */
public class RechargeRankDate : IMessageSerialize 
{
	//活动开始时间
	string _startTime;	
	//活动结束时间
	string _endTime;	
	//今日剩余时间 单位：秒
	int _todayLeftTime;	
	//0：关闭；1：开启
	int _type;	
	//当日奖励
	List<RankingReward> _dayReward = new List<RankingReward>();
	//总榜奖励
	List<RankingReward> _sumReward = new List<RankingReward>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//活动开始时间
		SerializeUtils.WriteString(stream, _startTime);
		//活动结束时间
		SerializeUtils.WriteString(stream, _endTime);
		//今日剩余时间 单位：秒
		SerializeUtils.WriteInt(stream, _todayLeftTime);
		//0：关闭；1：开启
		SerializeUtils.WriteInt(stream, _type);
		//当日奖励
		SerializeUtils.WriteShort(stream, (short)_dayReward.Count);

		foreach (var element in _dayReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//总榜奖励
		SerializeUtils.WriteShort(stream, (short)_sumReward.Count);

		foreach (var element in _sumReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//活动开始时间
		_startTime = SerializeUtils.ReadString(stream);
		//活动结束时间
		_endTime = SerializeUtils.ReadString(stream);
		//今日剩余时间 单位：秒
		_todayLeftTime = SerializeUtils.ReadInt(stream);
		//0：关闭；1：开启
		_type = SerializeUtils.ReadInt(stream);
		//当日奖励
		int _dayReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _dayReward_length; ++i) 
		{
			_dayReward.Add(SerializeUtils.ReadBean<RankingReward>(stream));
		}
		//总榜奖励
		int _sumReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _sumReward_length; ++i) 
		{
			_sumReward.Add(SerializeUtils.ReadBean<RankingReward>(stream));
		}
	}
	
	/**
	 * 活动开始时间
	 */
	public string StartTime
	{
		set { _startTime = value; }
	    get { return _startTime; }
	}
	
	/**
	 * 活动结束时间
	 */
	public string EndTime
	{
		set { _endTime = value; }
	    get { return _endTime; }
	}
	
	/**
	 * 今日剩余时间 单位：秒
	 */
	public int TodayLeftTime
	{
		set { _todayLeftTime = value; }
	    get { return _todayLeftTime; }
	}
	
	/**
	 * 0：关闭；1：开启
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * get 当日奖励
	 * @return 
	 */
	public List<RankingReward> GetDayReward()
	{
		return _dayReward;
	}
	
	/**
	 * set 当日奖励
	 */
	public void SetDayReward(List<RankingReward> dayReward)
	{
		_dayReward = dayReward;
	}
	
	/**
	 * get 总榜奖励
	 * @return 
	 */
	public List<RankingReward> GetSumReward()
	{
		return _sumReward;
	}
	
	/**
	 * set 总榜奖励
	 */
	public void SetSumReward(List<RankingReward> sumReward)
	{
		_sumReward = sumReward;
	}
	
}