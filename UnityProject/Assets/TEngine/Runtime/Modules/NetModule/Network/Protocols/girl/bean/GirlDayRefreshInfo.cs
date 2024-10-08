using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 妹子每日刷新
 */
public class GirlDayRefreshInfo : IMessageSerialize 
{
	//妹子id
	int _girlId;	
	//今日交往次数
	int _todayTimes;	
	//心情
	int _emotion;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//妹子id
		SerializeUtils.WriteInt(stream, _girlId);
		//今日交往次数
		SerializeUtils.WriteInt(stream, _todayTimes);
		//心情
		SerializeUtils.WriteInt(stream, _emotion);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//妹子id
		_girlId = SerializeUtils.ReadInt(stream);
		//今日交往次数
		_todayTimes = SerializeUtils.ReadInt(stream);
		//心情
		_emotion = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 妹子id
	 */
	public int GirlId
	{
		set { _girlId = value; }
	    get { return _girlId; }
	}
	
	/**
	 * 今日交往次数
	 */
	public int TodayTimes
	{
		set { _todayTimes = value; }
	    get { return _todayTimes; }
	}
	
	/**
	 * 心情
	 */
	public int Emotion
	{
		set { _emotion = value; }
	    get { return _emotion; }
	}
	
}