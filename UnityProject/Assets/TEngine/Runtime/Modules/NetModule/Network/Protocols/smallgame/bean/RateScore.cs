using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 蝴蝶的速度积分
 */
public class RateScore : IMessageSerialize 
{
	//速率
	int _rate;	
	//积分
	int _score;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//速率
		SerializeUtils.WriteInt(stream, _rate);
		//积分
		SerializeUtils.WriteInt(stream, _score);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//速率
		_rate = SerializeUtils.ReadInt(stream);
		//积分
		_score = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 速率
	 */
	public int Rate
	{
		set { _rate = value; }
	    get { return _rate; }
	}
	
	/**
	 * 积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
}