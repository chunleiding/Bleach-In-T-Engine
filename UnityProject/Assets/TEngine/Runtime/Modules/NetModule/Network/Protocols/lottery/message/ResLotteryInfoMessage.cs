using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 抽奖系统信息 message
 */
public class ResLotteryInfoMessage : Message 
{
	//
	LotteryInfo _lotteryInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//
		SerializeUtils.WriteBean(stream, _lotteryInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//
		_lotteryInfo = SerializeUtils.ReadBean<LotteryInfo>(stream);
	}
	
	/**
	 * 
	 */
	public LotteryInfo LotteryInfo
	{
		set { _lotteryInfo = value; }
	    get { return _lotteryInfo; }
	}
	
	
	public override int GetId() 
	{
		return 212201;
	}
}