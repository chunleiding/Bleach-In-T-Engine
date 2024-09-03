using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 领取者信息
 */
public class CollectorInfo : IMessageSerialize 
{
	//领取者姓名
	string _name;	
	//领取金额
	int _gold;	
	//最佳（0：不是最佳 1：最佳）
	int _isBest;	
	//领取者id
	long _id;	
	//领取时间
	long _time;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//领取者姓名
		SerializeUtils.WriteString(stream, _name);
		//领取金额
		SerializeUtils.WriteInt(stream, _gold);
		//最佳（0：不是最佳 1：最佳）
		SerializeUtils.WriteInt(stream, _isBest);
		//领取者id
		SerializeUtils.WriteLong(stream, _id);
		//领取时间
		SerializeUtils.WriteLong(stream, _time);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//领取者姓名
		_name = SerializeUtils.ReadString(stream);
		//领取金额
		_gold = SerializeUtils.ReadInt(stream);
		//最佳（0：不是最佳 1：最佳）
		_isBest = SerializeUtils.ReadInt(stream);
		//领取者id
		_id = SerializeUtils.ReadLong(stream);
		//领取时间
		_time = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 领取者姓名
	 */
	public string Name
	{
		set { _name = value; }
	    get { return _name; }
	}
	
	/**
	 * 领取金额
	 */
	public int Gold
	{
		set { _gold = value; }
	    get { return _gold; }
	}
	
	/**
	 * 最佳（0：不是最佳 1：最佳）
	 */
	public int IsBest
	{
		set { _isBest = value; }
	    get { return _isBest; }
	}
	
	/**
	 * 领取者id
	 */
	public long Id
	{
		set { _id = value; }
	    get { return _id; }
	}
	
	/**
	 * 领取时间
	 */
	public long Time
	{
		set { _time = value; }
	    get { return _time; }
	}
	
}