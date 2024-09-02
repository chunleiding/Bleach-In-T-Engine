using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 副本群玩家消息 message
 */
public class ResExplorePlayerInfoMessage : Message 
{
	//当前关卡id
	int _levelId;	
	//事件增减类型 0: 无事件 1：增 -1 ：减
	int _eventEffectId;	
	//玩家出战角色列表
	List<CharcaterLeftHpBean> _fightList = new List<CharcaterLeftHpBean>();
	//boss列表
	List<CharcaterLeftHpBean> _bossList = new List<CharcaterLeftHpBean>();
	//是否开启真boss宝箱 1：已开启 0：未开启
	int _isOpenBossCase;	
	//已经历的关卡
	List<LevelEventInfo> _experLevelList = new List<LevelEventInfo>();
	//玩家当前关卡的属性buff
	List<BuffTipBean> _buffTipList = new List<BuffTipBean>();
	//当前关卡剩余瞬步次数
	int _skipTimes;	
	//已触发buff的关卡Id
	List<int> _buffLevelList = new List<int>();
	//boss名字
	string _bossName;	
	//boss等级
	int _bossLevel;	
	//第一个探索度哒100%  0：未达到 1：达到
	int _isFirstFinishLevel;	
	//是否是最后一关通过 0：否 1：是
	int _isLastLevelFinish;	
	//已经通过的关卡列表
	List<int> _exploredList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//当前关卡id
		SerializeUtils.WriteInt(stream, _levelId);
		//事件增减类型 0: 无事件 1：增 -1 ：减
		SerializeUtils.WriteInt(stream, _eventEffectId);
		//玩家出战角色列表
		SerializeUtils.WriteShort(stream, (short)_fightList.Count);

		foreach (var element in _fightList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//boss列表
		SerializeUtils.WriteShort(stream, (short)_bossList.Count);

		foreach (var element in _bossList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//是否开启真boss宝箱 1：已开启 0：未开启
		SerializeUtils.WriteInt(stream, _isOpenBossCase);
		//已经历的关卡
		SerializeUtils.WriteShort(stream, (short)_experLevelList.Count);

		foreach (var element in _experLevelList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//玩家当前关卡的属性buff
		SerializeUtils.WriteShort(stream, (short)_buffTipList.Count);

		foreach (var element in _buffTipList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//当前关卡剩余瞬步次数
		SerializeUtils.WriteInt(stream, _skipTimes);
		//已触发buff的关卡Id
		SerializeUtils.WriteShort(stream, (short)_buffLevelList.Count);

		foreach (var element in _buffLevelList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//boss名字
		SerializeUtils.WriteString(stream, _bossName);
		//boss等级
		SerializeUtils.WriteInt(stream, _bossLevel);
		//第一个探索度哒100%  0：未达到 1：达到
		SerializeUtils.WriteInt(stream, _isFirstFinishLevel);
		//是否是最后一关通过 0：否 1：是
		SerializeUtils.WriteInt(stream, _isLastLevelFinish);
		//已经通过的关卡列表
		SerializeUtils.WriteShort(stream, (short)_exploredList.Count);

		foreach (var element in _exploredList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//当前关卡id
		_levelId = SerializeUtils.ReadInt(stream);
		//事件增减类型 0: 无事件 1：增 -1 ：减
		_eventEffectId = SerializeUtils.ReadInt(stream);
		//玩家出战角色列表
		int _fightList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _fightList_length; ++i) 
		{
			_fightList.Add(SerializeUtils.ReadBean<CharcaterLeftHpBean>(stream));
		}
		//boss列表
		int _bossList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _bossList_length; ++i) 
		{
			_bossList.Add(SerializeUtils.ReadBean<CharcaterLeftHpBean>(stream));
		}
		//是否开启真boss宝箱 1：已开启 0：未开启
		_isOpenBossCase = SerializeUtils.ReadInt(stream);
		//已经历的关卡
		int _experLevelList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _experLevelList_length; ++i) 
		{
			_experLevelList.Add(SerializeUtils.ReadBean<LevelEventInfo>(stream));
		}
		//玩家当前关卡的属性buff
		int _buffTipList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _buffTipList_length; ++i) 
		{
			_buffTipList.Add(SerializeUtils.ReadBean<BuffTipBean>(stream));
		}
		//当前关卡剩余瞬步次数
		_skipTimes = SerializeUtils.ReadInt(stream);
		//已触发buff的关卡Id
		int _buffLevelList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _buffLevelList_length; ++i) 
		{
			_buffLevelList.Add(SerializeUtils.ReadInt(stream));
		}
		//boss名字
		_bossName = SerializeUtils.ReadString(stream);
		//boss等级
		_bossLevel = SerializeUtils.ReadInt(stream);
		//第一个探索度哒100%  0：未达到 1：达到
		_isFirstFinishLevel = SerializeUtils.ReadInt(stream);
		//是否是最后一关通过 0：否 1：是
		_isLastLevelFinish = SerializeUtils.ReadInt(stream);
		//已经通过的关卡列表
		int _exploredList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _exploredList_length; ++i) 
		{
			_exploredList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 当前关卡id
	 */
	public int LevelId
	{
		set { _levelId = value; }
	    get { return _levelId; }
	}
	
	/**
	 * 事件增减类型 0: 无事件 1：增 -1 ：减
	 */
	public int EventEffectId
	{
		set { _eventEffectId = value; }
	    get { return _eventEffectId; }
	}
	
	/**
	 * get 玩家出战角色列表
	 * @return 
	 */
	public List<CharcaterLeftHpBean> GetFightList()
	{
		return _fightList;
	}
	
	/**
	 * set 玩家出战角色列表
	 */
	public void SetFightList(List<CharcaterLeftHpBean> fightList)
	{
		_fightList = fightList;
	}
	
	/**
	 * get boss列表
	 * @return 
	 */
	public List<CharcaterLeftHpBean> GetBossList()
	{
		return _bossList;
	}
	
	/**
	 * set boss列表
	 */
	public void SetBossList(List<CharcaterLeftHpBean> bossList)
	{
		_bossList = bossList;
	}
	
	/**
	 * 是否开启真boss宝箱 1：已开启 0：未开启
	 */
	public int IsOpenBossCase
	{
		set { _isOpenBossCase = value; }
	    get { return _isOpenBossCase; }
	}
	
	/**
	 * get 已经历的关卡
	 * @return 
	 */
	public List<LevelEventInfo> GetExperLevelList()
	{
		return _experLevelList;
	}
	
	/**
	 * set 已经历的关卡
	 */
	public void SetExperLevelList(List<LevelEventInfo> experLevelList)
	{
		_experLevelList = experLevelList;
	}
	
	/**
	 * get 玩家当前关卡的属性buff
	 * @return 
	 */
	public List<BuffTipBean> GetBuffTipList()
	{
		return _buffTipList;
	}
	
	/**
	 * set 玩家当前关卡的属性buff
	 */
	public void SetBuffTipList(List<BuffTipBean> buffTipList)
	{
		_buffTipList = buffTipList;
	}
	
	/**
	 * 当前关卡剩余瞬步次数
	 */
	public int SkipTimes
	{
		set { _skipTimes = value; }
	    get { return _skipTimes; }
	}
	
	/**
	 * get 已触发buff的关卡Id
	 * @return 
	 */
	public List<int> GetBuffLevelList()
	{
		return _buffLevelList;
	}
	
	/**
	 * set 已触发buff的关卡Id
	 */
	public void SetBuffLevelList(List<int> buffLevelList)
	{
		_buffLevelList = buffLevelList;
	}
	
	/**
	 * boss名字
	 */
	public string BossName
	{
		set { _bossName = value; }
	    get { return _bossName; }
	}
	
	/**
	 * boss等级
	 */
	public int BossLevel
	{
		set { _bossLevel = value; }
	    get { return _bossLevel; }
	}
	
	/**
	 * 第一个探索度哒100%  0：未达到 1：达到
	 */
	public int IsFirstFinishLevel
	{
		set { _isFirstFinishLevel = value; }
	    get { return _isFirstFinishLevel; }
	}
	
	/**
	 * 是否是最后一关通过 0：否 1：是
	 */
	public int IsLastLevelFinish
	{
		set { _isLastLevelFinish = value; }
	    get { return _isLastLevelFinish; }
	}
	
	/**
	 * get 已经通过的关卡列表
	 * @return 
	 */
	public List<int> GetExploredList()
	{
		return _exploredList;
	}
	
	/**
	 * set 已经通过的关卡列表
	 */
	public void SetExploredList(List<int> exploredList)
	{
		_exploredList = exploredList;
	}
	
	
	public override int GetId() 
	{
		return 831101;
	}
}