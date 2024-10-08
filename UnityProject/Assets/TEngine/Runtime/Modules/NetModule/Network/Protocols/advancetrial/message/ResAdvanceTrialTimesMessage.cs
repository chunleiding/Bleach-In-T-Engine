using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵力修炼挑战次数 message
 */
public class ResAdvanceTrialTimesMessage : Message 
{
	//当前剩余的挑战次数
	int _reduceTimes;	
	//当前购买的挑战次数
	int _buyTimes;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//当前剩余的挑战次数
		SerializeUtils.WriteInt(stream, _reduceTimes);
		//当前购买的挑战次数
		SerializeUtils.WriteInt(stream, _buyTimes);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//当前剩余的挑战次数
		_reduceTimes = SerializeUtils.ReadInt(stream);
		//当前购买的挑战次数
		_buyTimes = SerializeUtils.ReadInt(stream);
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
	
	
	public override int GetId() 
	{
		return 224102;
	}
}