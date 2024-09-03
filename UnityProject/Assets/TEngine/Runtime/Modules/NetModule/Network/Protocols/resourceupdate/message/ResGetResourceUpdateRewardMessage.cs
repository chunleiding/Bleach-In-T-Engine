using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 领奖回复 message
 */
public class ResGetResourceUpdateRewardMessage : Message 
{
	//0成功，1已领取，2领取失败
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0成功，1已领取，2领取失败
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0成功，1已领取，2领取失败
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0成功，1已领取，2领取失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 803103;
	}
}