using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 无双死神结算奖励时间 message
 */
public class ResPeerlessRewardTimeMessage : Message 
{
	//奖励结算剩余秒数
	int _seconds;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//奖励结算剩余秒数
		SerializeUtils.WriteInt(stream, _seconds);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//奖励结算剩余秒数
		_seconds = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 奖励结算剩余秒数
	 */
	public int Seconds
	{
		set { _seconds = value; }
	    get { return _seconds; }
	}
	
	
	public override int GetId() 
	{
		return 817107;
	}
}