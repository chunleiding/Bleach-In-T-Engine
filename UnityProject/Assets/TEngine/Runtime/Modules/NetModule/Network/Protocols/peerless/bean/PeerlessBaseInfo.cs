using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 无双死神基本信息
 */
public class PeerlessBaseInfo : IMessageSerialize 
{
	//剩余时间（秒）
	int _leftTime;	
	//状态 1：季前赛 2：季后赛 3：距离季前赛时间4：距离季后赛时间
	int _state;	
	//季前赛打满场次 季后赛登录奖励
	List<ItemInfo> _loginReward = new List<ItemInfo>();
	//单场胜利奖励
	List<ItemInfo> _winReward = new List<ItemInfo>();
	//单场失败奖励
	List<ItemInfo> _failReward = new List<ItemInfo>();
	//常规赛每日有奖场次
	int _dailyRewardSessions;	
	//季后赛每日登录领取条件 常规赛参与的次数
	int _loginRewardCondition;	
	//排名奖励
	List<PeerlessRankingReward> _rankingReward = new List<PeerlessRankingReward>();
	//是否领取过当天季后赛奖励 0：未领取1：领取
	int _isReceiveReward;	
	//季后赛每天战斗的次数
	int _PostFightTime;	
	//战场区间
	string _battleGroup;	
	//每天可膜拜的次数
	int _worshipNum;	
	//膜拜奖励
	List<ItemInfo> _worshipReward = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//剩余时间（秒）
		SerializeUtils.WriteInt(stream, _leftTime);
		//状态 1：季前赛 2：季后赛 3：距离季前赛时间4：距离季后赛时间
		SerializeUtils.WriteInt(stream, _state);
		//季前赛打满场次 季后赛登录奖励
		SerializeUtils.WriteShort(stream, (short)_loginReward.Count);

		foreach (var element in _loginReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//单场胜利奖励
		SerializeUtils.WriteShort(stream, (short)_winReward.Count);

		foreach (var element in _winReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//单场失败奖励
		SerializeUtils.WriteShort(stream, (short)_failReward.Count);

		foreach (var element in _failReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//常规赛每日有奖场次
		SerializeUtils.WriteInt(stream, _dailyRewardSessions);
		//季后赛每日登录领取条件 常规赛参与的次数
		SerializeUtils.WriteInt(stream, _loginRewardCondition);
		//排名奖励
		SerializeUtils.WriteShort(stream, (short)_rankingReward.Count);

		foreach (var element in _rankingReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//是否领取过当天季后赛奖励 0：未领取1：领取
		SerializeUtils.WriteInt(stream, _isReceiveReward);
		//季后赛每天战斗的次数
		SerializeUtils.WriteInt(stream, _PostFightTime);
		//战场区间
		SerializeUtils.WriteString(stream, _battleGroup);
		//每天可膜拜的次数
		SerializeUtils.WriteInt(stream, _worshipNum);
		//膜拜奖励
		SerializeUtils.WriteShort(stream, (short)_worshipReward.Count);

		foreach (var element in _worshipReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//剩余时间（秒）
		_leftTime = SerializeUtils.ReadInt(stream);
		//状态 1：季前赛 2：季后赛 3：距离季前赛时间4：距离季后赛时间
		_state = SerializeUtils.ReadInt(stream);
		//季前赛打满场次 季后赛登录奖励
		int _loginReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _loginReward_length; ++i) 
		{
			_loginReward.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//单场胜利奖励
		int _winReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _winReward_length; ++i) 
		{
			_winReward.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//单场失败奖励
		int _failReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _failReward_length; ++i) 
		{
			_failReward.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//常规赛每日有奖场次
		_dailyRewardSessions = SerializeUtils.ReadInt(stream);
		//季后赛每日登录领取条件 常规赛参与的次数
		_loginRewardCondition = SerializeUtils.ReadInt(stream);
		//排名奖励
		int _rankingReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rankingReward_length; ++i) 
		{
			_rankingReward.Add(SerializeUtils.ReadBean<PeerlessRankingReward>(stream));
		}
		//是否领取过当天季后赛奖励 0：未领取1：领取
		_isReceiveReward = SerializeUtils.ReadInt(stream);
		//季后赛每天战斗的次数
		_PostFightTime = SerializeUtils.ReadInt(stream);
		//战场区间
		_battleGroup = SerializeUtils.ReadString(stream);
		//每天可膜拜的次数
		_worshipNum = SerializeUtils.ReadInt(stream);
		//膜拜奖励
		int _worshipReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _worshipReward_length; ++i) 
		{
			_worshipReward.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * 剩余时间（秒）
	 */
	public int LeftTime
	{
		set { _leftTime = value; }
	    get { return _leftTime; }
	}
	
	/**
	 * 状态 1：季前赛 2：季后赛 3：距离季前赛时间4：距离季后赛时间
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	/**
	 * get 季前赛打满场次 季后赛登录奖励
	 * @return 
	 */
	public List<ItemInfo> GetLoginReward()
	{
		return _loginReward;
	}
	
	/**
	 * set 季前赛打满场次 季后赛登录奖励
	 */
	public void SetLoginReward(List<ItemInfo> loginReward)
	{
		_loginReward = loginReward;
	}
	
	/**
	 * get 单场胜利奖励
	 * @return 
	 */
	public List<ItemInfo> GetWinReward()
	{
		return _winReward;
	}
	
	/**
	 * set 单场胜利奖励
	 */
	public void SetWinReward(List<ItemInfo> winReward)
	{
		_winReward = winReward;
	}
	
	/**
	 * get 单场失败奖励
	 * @return 
	 */
	public List<ItemInfo> GetFailReward()
	{
		return _failReward;
	}
	
	/**
	 * set 单场失败奖励
	 */
	public void SetFailReward(List<ItemInfo> failReward)
	{
		_failReward = failReward;
	}
	
	/**
	 * 常规赛每日有奖场次
	 */
	public int DailyRewardSessions
	{
		set { _dailyRewardSessions = value; }
	    get { return _dailyRewardSessions; }
	}
	
	/**
	 * 季后赛每日登录领取条件 常规赛参与的次数
	 */
	public int LoginRewardCondition
	{
		set { _loginRewardCondition = value; }
	    get { return _loginRewardCondition; }
	}
	
	/**
	 * get 排名奖励
	 * @return 
	 */
	public List<PeerlessRankingReward> GetRankingReward()
	{
		return _rankingReward;
	}
	
	/**
	 * set 排名奖励
	 */
	public void SetRankingReward(List<PeerlessRankingReward> rankingReward)
	{
		_rankingReward = rankingReward;
	}
	
	/**
	 * 是否领取过当天季后赛奖励 0：未领取1：领取
	 */
	public int IsReceiveReward
	{
		set { _isReceiveReward = value; }
	    get { return _isReceiveReward; }
	}
	
	/**
	 * 季后赛每天战斗的次数
	 */
	public int PostFightTime
	{
		set { _PostFightTime = value; }
	    get { return _PostFightTime; }
	}
	
	/**
	 * 战场区间
	 */
	public string BattleGroup
	{
		set { _battleGroup = value; }
	    get { return _battleGroup; }
	}
	
	/**
	 * 每天可膜拜的次数
	 */
	public int WorshipNum
	{
		set { _worshipNum = value; }
	    get { return _worshipNum; }
	}
	
	/**
	 * get 膜拜奖励
	 * @return 
	 */
	public List<ItemInfo> GetWorshipReward()
	{
		return _worshipReward;
	}
	
	/**
	 * set 膜拜奖励
	 */
	public void SetWorshipReward(List<ItemInfo> worshipReward)
	{
		_worshipReward = worshipReward;
	}
	
}