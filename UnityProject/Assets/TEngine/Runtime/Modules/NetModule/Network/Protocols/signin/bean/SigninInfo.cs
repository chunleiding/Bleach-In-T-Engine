using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家签到信息
 */
public class SigninInfo : IMessageSerialize 
{
	//系统当前时间(时间戳,1970年以来的毫秒数)
	long _systemTime;	
	//今日是否已经签到（0：没有签到，非0：今日已经签到）
	byte _todaySigned;	
	//当月已签到次数
	int _monthSignedNum;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//系统当前时间(时间戳,1970年以来的毫秒数)
		SerializeUtils.WriteLong(stream, _systemTime);
		//今日是否已经签到（0：没有签到，非0：今日已经签到）
		SerializeUtils.WriteByte(stream, _todaySigned);
		//当月已签到次数
		SerializeUtils.WriteInt(stream, _monthSignedNum);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//系统当前时间(时间戳,1970年以来的毫秒数)
		_systemTime = SerializeUtils.ReadLong(stream);
		//今日是否已经签到（0：没有签到，非0：今日已经签到）
		_todaySigned = SerializeUtils.ReadByte(stream);
		//当月已签到次数
		_monthSignedNum = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 系统当前时间(时间戳,1970年以来的毫秒数)
	 */
	public long SystemTime
	{
		set { _systemTime = value; }
	    get { return _systemTime; }
	}
	
	/**
	 * 今日是否已经签到（0：没有签到，非0：今日已经签到）
	 */
	public byte TodaySigned
	{
		set { _todaySigned = value; }
	    get { return _todaySigned; }
	}
	
	/**
	 * 当月已签到次数
	 */
	public int MonthSignedNum
	{
		set { _monthSignedNum = value; }
	    get { return _monthSignedNum; }
	}
	
}