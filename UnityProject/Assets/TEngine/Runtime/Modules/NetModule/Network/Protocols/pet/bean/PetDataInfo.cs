using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家当前猪的数据
 */
public class PetDataInfo : IMessageSerialize 
{
	//玩家当前宠物等级
	int _petLevel;	
	//宠物当前经验
	int _petExp;	
	//今日总饱食度
	int _dailyAllSatiety;	
	//今日免费饱食度
	int _freeDailySatiety;	
	//付费今日饱食度
	int _payDailySatiety;	
	//宠物上一次喂食等级
	int _petOldLevel;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//玩家当前宠物等级
		SerializeUtils.WriteInt(stream, _petLevel);
		//宠物当前经验
		SerializeUtils.WriteInt(stream, _petExp);
		//今日总饱食度
		SerializeUtils.WriteInt(stream, _dailyAllSatiety);
		//今日免费饱食度
		SerializeUtils.WriteInt(stream, _freeDailySatiety);
		//付费今日饱食度
		SerializeUtils.WriteInt(stream, _payDailySatiety);
		//宠物上一次喂食等级
		SerializeUtils.WriteInt(stream, _petOldLevel);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//玩家当前宠物等级
		_petLevel = SerializeUtils.ReadInt(stream);
		//宠物当前经验
		_petExp = SerializeUtils.ReadInt(stream);
		//今日总饱食度
		_dailyAllSatiety = SerializeUtils.ReadInt(stream);
		//今日免费饱食度
		_freeDailySatiety = SerializeUtils.ReadInt(stream);
		//付费今日饱食度
		_payDailySatiety = SerializeUtils.ReadInt(stream);
		//宠物上一次喂食等级
		_petOldLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 玩家当前宠物等级
	 */
	public int PetLevel
	{
		set { _petLevel = value; }
	    get { return _petLevel; }
	}
	
	/**
	 * 宠物当前经验
	 */
	public int PetExp
	{
		set { _petExp = value; }
	    get { return _petExp; }
	}
	
	/**
	 * 今日总饱食度
	 */
	public int DailyAllSatiety
	{
		set { _dailyAllSatiety = value; }
	    get { return _dailyAllSatiety; }
	}
	
	/**
	 * 今日免费饱食度
	 */
	public int FreeDailySatiety
	{
		set { _freeDailySatiety = value; }
	    get { return _freeDailySatiety; }
	}
	
	/**
	 * 付费今日饱食度
	 */
	public int PayDailySatiety
	{
		set { _payDailySatiety = value; }
	    get { return _payDailySatiety; }
	}
	
	/**
	 * 宠物上一次喂食等级
	 */
	public int PetOldLevel
	{
		set { _petOldLevel = value; }
	    get { return _petOldLevel; }
	}
	
}