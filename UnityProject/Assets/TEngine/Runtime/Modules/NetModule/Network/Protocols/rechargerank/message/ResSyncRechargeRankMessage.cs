using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步排行榜信息 message
 */
public class ResSyncRechargeRankMessage : Message 
{
	//充值排行榜信息
	RechargeRankDate _recharge;	
	//消耗排行榜信息
	RechargeRankDate _consume;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//充值排行榜信息
		SerializeUtils.WriteBean(stream, _recharge);
		//消耗排行榜信息
		SerializeUtils.WriteBean(stream, _consume);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//充值排行榜信息
		_recharge = SerializeUtils.ReadBean<RechargeRankDate>(stream);
		//消耗排行榜信息
		_consume = SerializeUtils.ReadBean<RechargeRankDate>(stream);
	}
	
	/**
	 * 充值排行榜信息
	 */
	public RechargeRankDate Recharge
	{
		set { _recharge = value; }
	    get { return _recharge; }
	}
	
	/**
	 * 消耗排行榜信息
	 */
	public RechargeRankDate Consume
	{
		set { _consume = value; }
	    get { return _consume; }
	}
	
	
	public override int GetId() 
	{
		return 819105;
	}
}