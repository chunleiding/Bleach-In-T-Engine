using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 搜魂限制 message
 */
public class ResLotteryLimitInfoMessage : Message 
{
	//今日已抽次数(魂玉单抽)
	int _todayOneSoulTime;	
	//今日已抽奖次数(魂玉十连抽)
	int _todayTenSoulTimes;	
	//今日已抽奖次数(灵王宫搜魂)
	int _todaySpecialSoulTimes;	
	//单日魂玉单抽限制次数(为0不限制)
	int _oneSoulLimit;	
	//单日魂玉十连抽限制次数(为0不限制)
	int _tenSoulLimit;	
	//单日灵王宫搜魂次数限制(为0不限制)
	int _specialSoulLimit;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//今日已抽次数(魂玉单抽)
		SerializeUtils.WriteInt(stream, _todayOneSoulTime);
		//今日已抽奖次数(魂玉十连抽)
		SerializeUtils.WriteInt(stream, _todayTenSoulTimes);
		//今日已抽奖次数(灵王宫搜魂)
		SerializeUtils.WriteInt(stream, _todaySpecialSoulTimes);
		//单日魂玉单抽限制次数(为0不限制)
		SerializeUtils.WriteInt(stream, _oneSoulLimit);
		//单日魂玉十连抽限制次数(为0不限制)
		SerializeUtils.WriteInt(stream, _tenSoulLimit);
		//单日灵王宫搜魂次数限制(为0不限制)
		SerializeUtils.WriteInt(stream, _specialSoulLimit);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//今日已抽次数(魂玉单抽)
		_todayOneSoulTime = SerializeUtils.ReadInt(stream);
		//今日已抽奖次数(魂玉十连抽)
		_todayTenSoulTimes = SerializeUtils.ReadInt(stream);
		//今日已抽奖次数(灵王宫搜魂)
		_todaySpecialSoulTimes = SerializeUtils.ReadInt(stream);
		//单日魂玉单抽限制次数(为0不限制)
		_oneSoulLimit = SerializeUtils.ReadInt(stream);
		//单日魂玉十连抽限制次数(为0不限制)
		_tenSoulLimit = SerializeUtils.ReadInt(stream);
		//单日灵王宫搜魂次数限制(为0不限制)
		_specialSoulLimit = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 今日已抽次数(魂玉单抽)
	 */
	public int TodayOneSoulTime
	{
		set { _todayOneSoulTime = value; }
	    get { return _todayOneSoulTime; }
	}
	
	/**
	 * 今日已抽奖次数(魂玉十连抽)
	 */
	public int TodayTenSoulTimes
	{
		set { _todayTenSoulTimes = value; }
	    get { return _todayTenSoulTimes; }
	}
	
	/**
	 * 今日已抽奖次数(灵王宫搜魂)
	 */
	public int TodaySpecialSoulTimes
	{
		set { _todaySpecialSoulTimes = value; }
	    get { return _todaySpecialSoulTimes; }
	}
	
	/**
	 * 单日魂玉单抽限制次数(为0不限制)
	 */
	public int OneSoulLimit
	{
		set { _oneSoulLimit = value; }
	    get { return _oneSoulLimit; }
	}
	
	/**
	 * 单日魂玉十连抽限制次数(为0不限制)
	 */
	public int TenSoulLimit
	{
		set { _tenSoulLimit = value; }
	    get { return _tenSoulLimit; }
	}
	
	/**
	 * 单日灵王宫搜魂次数限制(为0不限制)
	 */
	public int SpecialSoulLimit
	{
		set { _specialSoulLimit = value; }
	    get { return _specialSoulLimit; }
	}
	
	
	public override int GetId() 
	{
		return 212203;
	}
}