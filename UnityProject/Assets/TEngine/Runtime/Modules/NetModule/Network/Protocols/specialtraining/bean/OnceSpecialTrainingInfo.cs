using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一轮特训信息
 */
public class OnceSpecialTrainingInfo : IMessageSerialize 
{
	//特训buffId
	int _buffId;	
	//等级
	int _level;	
	//遇到炸弹数量
	int _crossBomb;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//特训buffId
		SerializeUtils.WriteInt(stream, _buffId);
		//等级
		SerializeUtils.WriteInt(stream, _level);
		//遇到炸弹数量
		SerializeUtils.WriteInt(stream, _crossBomb);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//特训buffId
		_buffId = SerializeUtils.ReadInt(stream);
		//等级
		_level = SerializeUtils.ReadInt(stream);
		//遇到炸弹数量
		_crossBomb = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 特训buffId
	 */
	public int BuffId
	{
		set { _buffId = value; }
	    get { return _buffId; }
	}
	
	/**
	 * 等级
	 */
	public int Level
	{
		set { _level = value; }
	    get { return _level; }
	}
	
	/**
	 * 遇到炸弹数量
	 */
	public int CrossBomb
	{
		set { _crossBomb = value; }
	    get { return _crossBomb; }
	}
	
}