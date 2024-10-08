using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * VIP福利信息 message
 */
public class ResVipWelfareInfoMessage : Message 
{
	//今日是否领取了福利奖励[1:已经领取了,0:还没有领取]
	int _received;	
	//最近一次领取奖励时的vip等级
	int _receivedVip;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//今日是否领取了福利奖励[1:已经领取了,0:还没有领取]
		SerializeUtils.WriteInt(stream, _received);
		//最近一次领取奖励时的vip等级
		SerializeUtils.WriteInt(stream, _receivedVip);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//今日是否领取了福利奖励[1:已经领取了,0:还没有领取]
		_received = SerializeUtils.ReadInt(stream);
		//最近一次领取奖励时的vip等级
		_receivedVip = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 今日是否领取了福利奖励[1:已经领取了,0:还没有领取]
	 */
	public int Received
	{
		set { _received = value; }
	    get { return _received; }
	}
	
	/**
	 * 最近一次领取奖励时的vip等级
	 */
	public int ReceivedVip
	{
		set { _receivedVip = value; }
	    get { return _receivedVip; }
	}
	
	
	public override int GetId() 
	{
		return 315101;
	}
}