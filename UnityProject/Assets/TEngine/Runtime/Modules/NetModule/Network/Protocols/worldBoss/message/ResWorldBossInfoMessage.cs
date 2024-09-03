using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步boss信息 message
 */
public class ResWorldBossInfoMessage : Message 
{
	//boss基本信息
	BossInfo _bossInfo;	
	//魂玉购买buff价格
	int _soulPrice;	
	//灵子购买buff价格
	int _goldPrice;	
	//能使用的最大角色数量
	int _maxUseCharacter;	
	//面板上的活动开始时间介绍文字(后端全传)
	string _timeText;	
	//开始倒计时
	int _openLeftTime;	
	//战斗结束倒计时
	int _fightLeftTime;	
	//排行奖励
	List<WorldBossRewardItem> _rewardList = new List<WorldBossRewardItem>();
	//buff等级
	int _buffLevel;	
	//进地图限制时间(秒) 如:300
	int _enterMapLimitTime;	
	//最后一击奖励
	WorldBossRewardItem _finalAtkReward;	
	//角色血量
	List<SoulTrialHp> _hpList = new List<SoulTrialHp>();
	//世界boss场景buff列表
	List<int> _buffIds = new List<int>();
	//战斗结束前多久不能进入地图 eg:30(秒)
	int _cannotEnterMapTime;	
	//战斗总时长
	int _totalFightTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//boss基本信息
		SerializeUtils.WriteBean(stream, _bossInfo);
		//魂玉购买buff价格
		SerializeUtils.WriteInt(stream, _soulPrice);
		//灵子购买buff价格
		SerializeUtils.WriteInt(stream, _goldPrice);
		//能使用的最大角色数量
		SerializeUtils.WriteInt(stream, _maxUseCharacter);
		//面板上的活动开始时间介绍文字(后端全传)
		SerializeUtils.WriteString(stream, _timeText);
		//开始倒计时
		SerializeUtils.WriteInt(stream, _openLeftTime);
		//战斗结束倒计时
		SerializeUtils.WriteInt(stream, _fightLeftTime);
		//排行奖励
		SerializeUtils.WriteShort(stream, (short)_rewardList.Count);

		foreach (var element in _rewardList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//buff等级
		SerializeUtils.WriteInt(stream, _buffLevel);
		//进地图限制时间(秒) 如:300
		SerializeUtils.WriteInt(stream, _enterMapLimitTime);
		//最后一击奖励
		SerializeUtils.WriteBean(stream, _finalAtkReward);
		//角色血量
		SerializeUtils.WriteShort(stream, (short)_hpList.Count);

		foreach (var element in _hpList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//世界boss场景buff列表
		SerializeUtils.WriteShort(stream, (short)_buffIds.Count);

		foreach (var element in _buffIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//战斗结束前多久不能进入地图 eg:30(秒)
		SerializeUtils.WriteInt(stream, _cannotEnterMapTime);
		//战斗总时长
		SerializeUtils.WriteInt(stream, _totalFightTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//boss基本信息
		_bossInfo = SerializeUtils.ReadBean<BossInfo>(stream);
		//魂玉购买buff价格
		_soulPrice = SerializeUtils.ReadInt(stream);
		//灵子购买buff价格
		_goldPrice = SerializeUtils.ReadInt(stream);
		//能使用的最大角色数量
		_maxUseCharacter = SerializeUtils.ReadInt(stream);
		//面板上的活动开始时间介绍文字(后端全传)
		_timeText = SerializeUtils.ReadString(stream);
		//开始倒计时
		_openLeftTime = SerializeUtils.ReadInt(stream);
		//战斗结束倒计时
		_fightLeftTime = SerializeUtils.ReadInt(stream);
		//排行奖励
		int _rewardList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardList_length; ++i) 
		{
			_rewardList.Add(SerializeUtils.ReadBean<WorldBossRewardItem>(stream));
		}
		//buff等级
		_buffLevel = SerializeUtils.ReadInt(stream);
		//进地图限制时间(秒) 如:300
		_enterMapLimitTime = SerializeUtils.ReadInt(stream);
		//最后一击奖励
		_finalAtkReward = SerializeUtils.ReadBean<WorldBossRewardItem>(stream);
		//角色血量
		int _hpList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _hpList_length; ++i) 
		{
			_hpList.Add(SerializeUtils.ReadBean<SoulTrialHp>(stream));
		}
		//世界boss场景buff列表
		int _buffIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _buffIds_length; ++i) 
		{
			_buffIds.Add(SerializeUtils.ReadInt(stream));
		}
		//战斗结束前多久不能进入地图 eg:30(秒)
		_cannotEnterMapTime = SerializeUtils.ReadInt(stream);
		//战斗总时长
		_totalFightTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * boss基本信息
	 */
	public BossInfo BossInfo
	{
		set { _bossInfo = value; }
	    get { return _bossInfo; }
	}
	
	/**
	 * 魂玉购买buff价格
	 */
	public int SoulPrice
	{
		set { _soulPrice = value; }
	    get { return _soulPrice; }
	}
	
	/**
	 * 灵子购买buff价格
	 */
	public int GoldPrice
	{
		set { _goldPrice = value; }
	    get { return _goldPrice; }
	}
	
	/**
	 * 能使用的最大角色数量
	 */
	public int MaxUseCharacter
	{
		set { _maxUseCharacter = value; }
	    get { return _maxUseCharacter; }
	}
	
	/**
	 * 面板上的活动开始时间介绍文字(后端全传)
	 */
	public string TimeText
	{
		set { _timeText = value; }
	    get { return _timeText; }
	}
	
	/**
	 * 开始倒计时
	 */
	public int OpenLeftTime
	{
		set { _openLeftTime = value; }
	    get { return _openLeftTime; }
	}
	
	/**
	 * 战斗结束倒计时
	 */
	public int FightLeftTime
	{
		set { _fightLeftTime = value; }
	    get { return _fightLeftTime; }
	}
	
	/**
	 * get 排行奖励
	 * @return 
	 */
	public List<WorldBossRewardItem> GetRewardList()
	{
		return _rewardList;
	}
	
	/**
	 * set 排行奖励
	 */
	public void SetRewardList(List<WorldBossRewardItem> rewardList)
	{
		_rewardList = rewardList;
	}
	
	/**
	 * buff等级
	 */
	public int BuffLevel
	{
		set { _buffLevel = value; }
	    get { return _buffLevel; }
	}
	
	/**
	 * 进地图限制时间(秒) 如:300
	 */
	public int EnterMapLimitTime
	{
		set { _enterMapLimitTime = value; }
	    get { return _enterMapLimitTime; }
	}
	
	/**
	 * 最后一击奖励
	 */
	public WorldBossRewardItem FinalAtkReward
	{
		set { _finalAtkReward = value; }
	    get { return _finalAtkReward; }
	}
	
	/**
	 * get 角色血量
	 * @return 
	 */
	public List<SoulTrialHp> GetHpList()
	{
		return _hpList;
	}
	
	/**
	 * set 角色血量
	 */
	public void SetHpList(List<SoulTrialHp> hpList)
	{
		_hpList = hpList;
	}
	
	/**
	 * get 世界boss场景buff列表
	 * @return 
	 */
	public List<int> GetBuffIds()
	{
		return _buffIds;
	}
	
	/**
	 * set 世界boss场景buff列表
	 */
	public void SetBuffIds(List<int> buffIds)
	{
		_buffIds = buffIds;
	}
	
	/**
	 * 战斗结束前多久不能进入地图 eg:30(秒)
	 */
	public int CannotEnterMapTime
	{
		set { _cannotEnterMapTime = value; }
	    get { return _cannotEnterMapTime; }
	}
	
	/**
	 * 战斗总时长
	 */
	public int TotalFightTime
	{
		set { _totalFightTime = value; }
	    get { return _totalFightTime; }
	}
	
	
	public override int GetId() 
	{
		return 807102;
	}
}