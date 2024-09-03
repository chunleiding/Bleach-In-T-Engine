using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 购买抽奖道具消息 message
 */
public class ReqBuyLotteryItemMessage : Message 
{
	//0:购买银箱子道具，1:购买金箱子道具
	int _type;	
	//购买道具数量
	int _num;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:购买银箱子道具，1:购买金箱子道具
		SerializeUtils.WriteInt(stream, _type);
		//购买道具数量
		SerializeUtils.WriteInt(stream, _num);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:购买银箱子道具，1:购买金箱子道具
		_type = SerializeUtils.ReadInt(stream);
		//购买道具数量
		_num = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:购买银箱子道具，1:购买金箱子道具
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 购买道具数量
	 */
	public int Num
	{
		set { _num = value; }
	    get { return _num; }
	}
	
	
	public override int GetId() 
	{
		return 212204;
	}
}