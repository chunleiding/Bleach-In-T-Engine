using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队福袋发放信息
 */
public class GangBagGiveInfo : IMessageSerialize 
{
	//福袋类型
	int _type;	
	//该福袋类型剩余可以发放次数(基础的和活动赠送的)
	int _lastNum;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//福袋类型
		SerializeUtils.WriteInt(stream, _type);
		//该福袋类型剩余可以发放次数(基础的和活动赠送的)
		SerializeUtils.WriteInt(stream, _lastNum);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//福袋类型
		_type = SerializeUtils.ReadInt(stream);
		//该福袋类型剩余可以发放次数(基础的和活动赠送的)
		_lastNum = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 福袋类型
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 该福袋类型剩余可以发放次数(基础的和活动赠送的)
	 */
	public int LastNum
	{
		set { _lastNum = value; }
	    get { return _lastNum; }
	}
	
}