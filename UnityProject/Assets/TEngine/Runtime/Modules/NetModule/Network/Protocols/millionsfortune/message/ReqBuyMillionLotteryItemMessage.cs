using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 购买百万招财抽奖道具消息 message
 */
public class ReqBuyMillionLotteryItemMessage : Message 
{
	//数量
	int _num;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//数量
		SerializeUtils.WriteInt(stream, _num);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//数量
		_num = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 数量
	 */
	public int Num
	{
		set { _num = value; }
	    get { return _num; }
	}
	
	
	public override int GetId() 
	{
		return 316206;
	}
}