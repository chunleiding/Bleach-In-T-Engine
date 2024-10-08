using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 妹子信息
 */
public class GirlInfo : IMessageSerialize 
{
	//妹子id
	int _girlId;	
	//对应buff的等级
	int _buffLevel;	
	//今日交往次数
	int _todayTimes;	
	//心情
	int _emotion;	
	//距离下次交往冷却时间（秒）
	int _cdTime;	
	//时装id
	List<int> _dressIds = new List<int>();
	//当前时装id
	int _nowDress;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//妹子id
		SerializeUtils.WriteInt(stream, _girlId);
		//对应buff的等级
		SerializeUtils.WriteInt(stream, _buffLevel);
		//今日交往次数
		SerializeUtils.WriteInt(stream, _todayTimes);
		//心情
		SerializeUtils.WriteInt(stream, _emotion);
		//距离下次交往冷却时间（秒）
		SerializeUtils.WriteInt(stream, _cdTime);
		//时装id
		SerializeUtils.WriteShort(stream, (short)_dressIds.Count);

		foreach (var element in _dressIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//当前时装id
		SerializeUtils.WriteInt(stream, _nowDress);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//妹子id
		_girlId = SerializeUtils.ReadInt(stream);
		//对应buff的等级
		_buffLevel = SerializeUtils.ReadInt(stream);
		//今日交往次数
		_todayTimes = SerializeUtils.ReadInt(stream);
		//心情
		_emotion = SerializeUtils.ReadInt(stream);
		//距离下次交往冷却时间（秒）
		_cdTime = SerializeUtils.ReadInt(stream);
		//时装id
		int _dressIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _dressIds_length; ++i) 
		{
			_dressIds.Add(SerializeUtils.ReadInt(stream));
		}
		//当前时装id
		_nowDress = SerializeUtils.ReadInt(stream);
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
	 * 对应buff的等级
	 */
	public int BuffLevel
	{
		set { _buffLevel = value; }
	    get { return _buffLevel; }
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
	
	/**
	 * 距离下次交往冷却时间（秒）
	 */
	public int CdTime
	{
		set { _cdTime = value; }
	    get { return _cdTime; }
	}
	
	/**
	 * get 时装id
	 * @return 
	 */
	public List<int> GetDressIds()
	{
		return _dressIds;
	}
	
	/**
	 * set 时装id
	 */
	public void SetDressIds(List<int> dressIds)
	{
		_dressIds = dressIds;
	}
	
	/**
	 * 当前时装id
	 */
	public int NowDress
	{
		set { _nowDress = value; }
	    get { return _nowDress; }
	}
	
}