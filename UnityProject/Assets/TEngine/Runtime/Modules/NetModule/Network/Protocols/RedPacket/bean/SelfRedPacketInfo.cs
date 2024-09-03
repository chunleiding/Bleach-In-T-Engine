using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 个人红包信息
 */
public class SelfRedPacketInfo : IMessageSerialize 
{
	//收取红包总金额
	int _receiveGold;	
	//发送红包总金额
	int _sendGold;	
	//收取红包总个数
	int _receiveCount;	
	//发送红包总个数
	int _sendCount;	
	//手气最佳个数
	int _receiveBestCount;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//收取红包总金额
		SerializeUtils.WriteInt(stream, _receiveGold);
		//发送红包总金额
		SerializeUtils.WriteInt(stream, _sendGold);
		//收取红包总个数
		SerializeUtils.WriteInt(stream, _receiveCount);
		//发送红包总个数
		SerializeUtils.WriteInt(stream, _sendCount);
		//手气最佳个数
		SerializeUtils.WriteInt(stream, _receiveBestCount);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//收取红包总金额
		_receiveGold = SerializeUtils.ReadInt(stream);
		//发送红包总金额
		_sendGold = SerializeUtils.ReadInt(stream);
		//收取红包总个数
		_receiveCount = SerializeUtils.ReadInt(stream);
		//发送红包总个数
		_sendCount = SerializeUtils.ReadInt(stream);
		//手气最佳个数
		_receiveBestCount = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 收取红包总金额
	 */
	public int ReceiveGold
	{
		set { _receiveGold = value; }
	    get { return _receiveGold; }
	}
	
	/**
	 * 发送红包总金额
	 */
	public int SendGold
	{
		set { _sendGold = value; }
	    get { return _sendGold; }
	}
	
	/**
	 * 收取红包总个数
	 */
	public int ReceiveCount
	{
		set { _receiveCount = value; }
	    get { return _receiveCount; }
	}
	
	/**
	 * 发送红包总个数
	 */
	public int SendCount
	{
		set { _sendCount = value; }
	    get { return _sendCount; }
	}
	
	/**
	 * 手气最佳个数
	 */
	public int ReceiveBestCount
	{
		set { _receiveBestCount = value; }
	    get { return _receiveBestCount; }
	}
	
}