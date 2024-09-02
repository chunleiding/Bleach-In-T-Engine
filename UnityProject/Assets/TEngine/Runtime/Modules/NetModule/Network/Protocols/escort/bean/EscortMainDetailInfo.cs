using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 护送主界面信息
 */
public class EscortMainDetailInfo : IMessageSerialize 
{
	//今日护送剩余次数
	int _escortOverNum;	
	//今日换一批剩余次数
	int _chargeOverNum;	
	//清除换一批倒计时需要的魂玉
	int _clearChargeTimeCost;	
	//特殊护送时段和加成值
	string _escortSpecial;	
	//星星的个数
	int _starNum;	
	//满星魂玉消耗
	int _allStartCost;	
	//单次魂玉消耗
	int _onceCost;	
	//玩家奖励基数列表
	List<EscortRewardBase> _rewardBase = new List<EscortRewardBase>();
	//已经护送过的英雄列表
	List<int> _usedCharactes = new List<int>();
	//奖励比例(万分比分子)
	int _rewardRatio;	
	// 清除剩余护送时间，每分钟消耗魂玉
	int _clearEscortTime;	
	//总共护送时间
	int _totalTime;	
	//总共可以被抢次数
	int _robAllNumber;	
	//参与打劫的角色
	List<int> _fightedList = new List<int>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//今日护送剩余次数
		SerializeUtils.WriteInt(stream, _escortOverNum);
		//今日换一批剩余次数
		SerializeUtils.WriteInt(stream, _chargeOverNum);
		//清除换一批倒计时需要的魂玉
		SerializeUtils.WriteInt(stream, _clearChargeTimeCost);
		//特殊护送时段和加成值
		SerializeUtils.WriteString(stream, _escortSpecial);
		//星星的个数
		SerializeUtils.WriteInt(stream, _starNum);
		//满星魂玉消耗
		SerializeUtils.WriteInt(stream, _allStartCost);
		//单次魂玉消耗
		SerializeUtils.WriteInt(stream, _onceCost);
		//玩家奖励基数列表
		SerializeUtils.WriteShort(stream, (short)_rewardBase.Count);

		foreach (var element in _rewardBase)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//已经护送过的英雄列表
		SerializeUtils.WriteShort(stream, (short)_usedCharactes.Count);

		foreach (var element in _usedCharactes)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//奖励比例(万分比分子)
		SerializeUtils.WriteInt(stream, _rewardRatio);
		// 清除剩余护送时间，每分钟消耗魂玉
		SerializeUtils.WriteInt(stream, _clearEscortTime);
		//总共护送时间
		SerializeUtils.WriteInt(stream, _totalTime);
		//总共可以被抢次数
		SerializeUtils.WriteInt(stream, _robAllNumber);
		//参与打劫的角色
		SerializeUtils.WriteShort(stream, (short)_fightedList.Count);

		foreach (var element in _fightedList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//今日护送剩余次数
		_escortOverNum = SerializeUtils.ReadInt(stream);
		//今日换一批剩余次数
		_chargeOverNum = SerializeUtils.ReadInt(stream);
		//清除换一批倒计时需要的魂玉
		_clearChargeTimeCost = SerializeUtils.ReadInt(stream);
		//特殊护送时段和加成值
		_escortSpecial = SerializeUtils.ReadString(stream);
		//星星的个数
		_starNum = SerializeUtils.ReadInt(stream);
		//满星魂玉消耗
		_allStartCost = SerializeUtils.ReadInt(stream);
		//单次魂玉消耗
		_onceCost = SerializeUtils.ReadInt(stream);
		//玩家奖励基数列表
		int _rewardBase_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardBase_length; ++i) 
		{
			_rewardBase.Add(SerializeUtils.ReadBean<EscortRewardBase>(stream));
		}
		//已经护送过的英雄列表
		int _usedCharactes_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _usedCharactes_length; ++i) 
		{
			_usedCharactes.Add(SerializeUtils.ReadInt(stream));
		}
		//奖励比例(万分比分子)
		_rewardRatio = SerializeUtils.ReadInt(stream);
		// 清除剩余护送时间，每分钟消耗魂玉
		_clearEscortTime = SerializeUtils.ReadInt(stream);
		//总共护送时间
		_totalTime = SerializeUtils.ReadInt(stream);
		//总共可以被抢次数
		_robAllNumber = SerializeUtils.ReadInt(stream);
		//参与打劫的角色
		int _fightedList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _fightedList_length; ++i) 
		{
			_fightedList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 今日护送剩余次数
	 */
	public int EscortOverNum
	{
		set { _escortOverNum = value; }
	    get { return _escortOverNum; }
	}
	
	/**
	 * 今日换一批剩余次数
	 */
	public int ChargeOverNum
	{
		set { _chargeOverNum = value; }
	    get { return _chargeOverNum; }
	}
	
	/**
	 * 清除换一批倒计时需要的魂玉
	 */
	public int ClearChargeTimeCost
	{
		set { _clearChargeTimeCost = value; }
	    get { return _clearChargeTimeCost; }
	}
	
	/**
	 * 特殊护送时段和加成值
	 */
	public string EscortSpecial
	{
		set { _escortSpecial = value; }
	    get { return _escortSpecial; }
	}
	
	/**
	 * 星星的个数
	 */
	public int StarNum
	{
		set { _starNum = value; }
	    get { return _starNum; }
	}
	
	/**
	 * 满星魂玉消耗
	 */
	public int AllStartCost
	{
		set { _allStartCost = value; }
	    get { return _allStartCost; }
	}
	
	/**
	 * 单次魂玉消耗
	 */
	public int OnceCost
	{
		set { _onceCost = value; }
	    get { return _onceCost; }
	}
	
	/**
	 * get 玩家奖励基数列表
	 * @return 
	 */
	public List<EscortRewardBase> GetRewardBase()
	{
		return _rewardBase;
	}
	
	/**
	 * set 玩家奖励基数列表
	 */
	public void SetRewardBase(List<EscortRewardBase> rewardBase)
	{
		_rewardBase = rewardBase;
	}
	
	/**
	 * get 已经护送过的英雄列表
	 * @return 
	 */
	public List<int> GetUsedCharactes()
	{
		return _usedCharactes;
	}
	
	/**
	 * set 已经护送过的英雄列表
	 */
	public void SetUsedCharactes(List<int> usedCharactes)
	{
		_usedCharactes = usedCharactes;
	}
	
	/**
	 * 奖励比例(万分比分子)
	 */
	public int RewardRatio
	{
		set { _rewardRatio = value; }
	    get { return _rewardRatio; }
	}
	
	/**
	 *  清除剩余护送时间，每分钟消耗魂玉
	 */
	public int ClearEscortTime
	{
		set { _clearEscortTime = value; }
	    get { return _clearEscortTime; }
	}
	
	/**
	 * 总共护送时间
	 */
	public int TotalTime
	{
		set { _totalTime = value; }
	    get { return _totalTime; }
	}
	
	/**
	 * 总共可以被抢次数
	 */
	public int RobAllNumber
	{
		set { _robAllNumber = value; }
	    get { return _robAllNumber; }
	}
	
	/**
	 * get 参与打劫的角色
	 * @return 
	 */
	public List<int> GetFightedList()
	{
		return _fightedList;
	}
	
	/**
	 * set 参与打劫的角色
	 */
	public void SetFightedList(List<int> fightedList)
	{
		_fightedList = fightedList;
	}
	
}