using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 是否能够充值 message
 */
public class ResRechargeStateMessage : Message 
{
	//0-为开放 1-已开放
	int _state;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0-为开放 1-已开放
		SerializeUtils.WriteInt(stream, _state);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0-为开放 1-已开放
		_state = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0-为开放 1-已开放
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	
	public override int GetId() 
	{
		return 312107;
	}
}