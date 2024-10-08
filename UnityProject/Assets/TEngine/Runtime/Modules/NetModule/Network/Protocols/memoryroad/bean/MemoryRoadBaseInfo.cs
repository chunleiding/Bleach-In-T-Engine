using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 记忆之路基础信息
 */
public class MemoryRoadBaseInfo : IMessageSerialize 
{
	//当前剩余的挑战次数
	int _reduceTimes;	
	//当前购买的挑战次数
	int _buyTimes;	
	//上次领取奖励时的胜利总次数
	int _receivedWinTimes;	
	//当前胜利总次数
	int _winTimes;	
	//0:可以领奖，非0：下一次领取周期奖励的倒计时[秒]
	int _cycleRewardCdSeconds;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//当前剩余的挑战次数
		SerializeUtils.WriteInt(stream, _reduceTimes);
		//当前购买的挑战次数
		SerializeUtils.WriteInt(stream, _buyTimes);
		//上次领取奖励时的胜利总次数
		SerializeUtils.WriteInt(stream, _receivedWinTimes);
		//当前胜利总次数
		SerializeUtils.WriteInt(stream, _winTimes);
		//0:可以领奖，非0：下一次领取周期奖励的倒计时[秒]
		SerializeUtils.WriteInt(stream, _cycleRewardCdSeconds);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//当前剩余的挑战次数
		_reduceTimes = SerializeUtils.ReadInt(stream);
		//当前购买的挑战次数
		_buyTimes = SerializeUtils.ReadInt(stream);
		//上次领取奖励时的胜利总次数
		_receivedWinTimes = SerializeUtils.ReadInt(stream);
		//当前胜利总次数
		_winTimes = SerializeUtils.ReadInt(stream);
		//0:可以领奖，非0：下一次领取周期奖励的倒计时[秒]
		_cycleRewardCdSeconds = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 当前剩余的挑战次数
	 */
	public int ReduceTimes
	{
		set { _reduceTimes = value; }
	    get { return _reduceTimes; }
	}
	
	/**
	 * 当前购买的挑战次数
	 */
	public int BuyTimes
	{
		set { _buyTimes = value; }
	    get { return _buyTimes; }
	}
	
	/**
	 * 上次领取奖励时的胜利总次数
	 */
	public int ReceivedWinTimes
	{
		set { _receivedWinTimes = value; }
	    get { return _receivedWinTimes; }
	}
	
	/**
	 * 当前胜利总次数
	 */
	public int WinTimes
	{
		set { _winTimes = value; }
	    get { return _winTimes; }
	}
	
	/**
	 * 0:可以领奖，非0：下一次领取周期奖励的倒计时[秒]
	 */
	public int CycleRewardCdSeconds
	{
		set { _cycleRewardCdSeconds = value; }
	    get { return _cycleRewardCdSeconds; }
	}
	
}