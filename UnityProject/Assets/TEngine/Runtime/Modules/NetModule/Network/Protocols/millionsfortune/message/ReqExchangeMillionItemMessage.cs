using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求用百万招财积分兑换奖励消息 message
 */
public class ReqExchangeMillionItemMessage : Message 
{
	//请求兑换的奖励序号
	int _index;	
	//兑换奖励次数
	int _count;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//请求兑换的奖励序号
		SerializeUtils.WriteInt(stream, _index);
		//兑换奖励次数
		SerializeUtils.WriteInt(stream, _count);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//请求兑换的奖励序号
		_index = SerializeUtils.ReadInt(stream);
		//兑换奖励次数
		_count = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 请求兑换的奖励序号
	 */
	public int Index
	{
		set { _index = value; }
	    get { return _index; }
	}
	
	/**
	 * 兑换奖励次数
	 */
	public int Count
	{
		set { _count = value; }
	    get { return _count; }
	}
	
	public override int GetId() 
	{
		return 316202;
	}
}