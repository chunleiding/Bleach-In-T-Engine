using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步boss信息 message
 */
public class ResWorldBossSyncMessage : Message 
{
	//boss基本信息
	BossInfo _bossInfo;	
	//距离开始剩余时间（-1：今日已经完成 0：开始：>0：还有多久开始）
	int _overTime;	
	//魂玉购买buff价格
	int _soulPrice;	
	//灵子购买buff价格
	int _goldPrice;	
	//能使用的最大角色数量
	int _maxUseCharacter;	
	//面板上的活动开始时间介绍文字(后端全传)
	string _timeText;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//boss基本信息
		SerializeUtils.WriteBean(stream, _bossInfo);
		//距离开始剩余时间（-1：今日已经完成 0：开始：>0：还有多久开始）
		SerializeUtils.WriteInt(stream, _overTime);
		//魂玉购买buff价格
		SerializeUtils.WriteInt(stream, _soulPrice);
		//灵子购买buff价格
		SerializeUtils.WriteInt(stream, _goldPrice);
		//能使用的最大角色数量
		SerializeUtils.WriteInt(stream, _maxUseCharacter);
		//面板上的活动开始时间介绍文字(后端全传)
		SerializeUtils.WriteString(stream, _timeText);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//boss基本信息
		_bossInfo = SerializeUtils.ReadBean<BossInfo>(stream);
		//距离开始剩余时间（-1：今日已经完成 0：开始：>0：还有多久开始）
		_overTime = SerializeUtils.ReadInt(stream);
		//魂玉购买buff价格
		_soulPrice = SerializeUtils.ReadInt(stream);
		//灵子购买buff价格
		_goldPrice = SerializeUtils.ReadInt(stream);
		//能使用的最大角色数量
		_maxUseCharacter = SerializeUtils.ReadInt(stream);
		//面板上的活动开始时间介绍文字(后端全传)
		_timeText = SerializeUtils.ReadString(stream);
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
	 * 距离开始剩余时间（-1：今日已经完成 0：开始：>0：还有多久开始）
	 */
	public int OverTime
	{
		set { _overTime = value; }
	    get { return _overTime; }
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
	
	
	public override int GetId() 
	{
		return 807102;
	}
}