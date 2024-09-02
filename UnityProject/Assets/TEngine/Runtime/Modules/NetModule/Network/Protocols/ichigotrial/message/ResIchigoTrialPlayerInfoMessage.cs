using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一护的试炼玩家基本消息 message
 */
public class ResIchigoTrialPlayerInfoMessage : Message 
{
	//一护试炼剩余兑换次数
	int _leftExchangeTimes;	
	//已购买挑战次数
	int _buyTimes;	
	//剩余挑战次数
	int _leftTimes;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//一护试炼剩余兑换次数
		SerializeUtils.WriteInt(stream, _leftExchangeTimes);
		//已购买挑战次数
		SerializeUtils.WriteInt(stream, _buyTimes);
		//剩余挑战次数
		SerializeUtils.WriteInt(stream, _leftTimes);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//一护试炼剩余兑换次数
		_leftExchangeTimes = SerializeUtils.ReadInt(stream);
		//已购买挑战次数
		_buyTimes = SerializeUtils.ReadInt(stream);
		//剩余挑战次数
		_leftTimes = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 一护试炼剩余兑换次数
	 */
	public int LeftExchangeTimes
	{
		set { _leftExchangeTimes = value; }
	    get { return _leftExchangeTimes; }
	}
	
	/**
	 * 已购买挑战次数
	 */
	public int BuyTimes
	{
		set { _buyTimes = value; }
	    get { return _buyTimes; }
	}
	
	/**
	 * 剩余挑战次数
	 */
	public int LeftTimes
	{
		set { _leftTimes = value; }
	    get { return _leftTimes; }
	}
	
	
	public override int GetId() 
	{
		return 825106;
	}
}