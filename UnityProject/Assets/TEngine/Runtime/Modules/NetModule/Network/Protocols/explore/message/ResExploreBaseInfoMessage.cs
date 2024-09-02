using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 副本群基础消息 message
 */
public class ResExploreBaseInfoMessage : Message 
{
	//活动剩余时间
	int _lessTime;	
	//已购买挑战次数
	int _boughtTimes;	
	//剩余挑战次数
	int _challengeTimes;	
	//上一轮玩家所选角色
	List<int> _lastRoundAcotrList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//活动剩余时间
		SerializeUtils.WriteInt(stream, _lessTime);
		//已购买挑战次数
		SerializeUtils.WriteInt(stream, _boughtTimes);
		//剩余挑战次数
		SerializeUtils.WriteInt(stream, _challengeTimes);
		//上一轮玩家所选角色
		SerializeUtils.WriteShort(stream, (short)_lastRoundAcotrList.Count);

		foreach (var element in _lastRoundAcotrList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//活动剩余时间
		_lessTime = SerializeUtils.ReadInt(stream);
		//已购买挑战次数
		_boughtTimes = SerializeUtils.ReadInt(stream);
		//剩余挑战次数
		_challengeTimes = SerializeUtils.ReadInt(stream);
		//上一轮玩家所选角色
		int _lastRoundAcotrList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _lastRoundAcotrList_length; ++i) 
		{
			_lastRoundAcotrList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 活动剩余时间
	 */
	public int LessTime
	{
		set { _lessTime = value; }
	    get { return _lessTime; }
	}
	
	/**
	 * 已购买挑战次数
	 */
	public int BoughtTimes
	{
		set { _boughtTimes = value; }
	    get { return _boughtTimes; }
	}
	
	/**
	 * 剩余挑战次数
	 */
	public int ChallengeTimes
	{
		set { _challengeTimes = value; }
	    get { return _challengeTimes; }
	}
	
	/**
	 * get 上一轮玩家所选角色
	 * @return 
	 */
	public List<int> GetLastRoundAcotrList()
	{
		return _lastRoundAcotrList;
	}
	
	/**
	 * set 上一轮玩家所选角色
	 */
	public void SetLastRoundAcotrList(List<int> lastRoundAcotrList)
	{
		_lastRoundAcotrList = lastRoundAcotrList;
	}
	
	
	public override int GetId() 
	{
		return 831100;
	}
}