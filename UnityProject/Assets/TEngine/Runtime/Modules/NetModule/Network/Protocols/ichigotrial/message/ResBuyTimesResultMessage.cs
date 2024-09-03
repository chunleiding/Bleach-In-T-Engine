using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 购买挑战次数回复 message
 */
public class ResBuyTimesResultMessage : Message 
{
	//0：成功；大于：失败的原因
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功；大于：失败的原因
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功；大于：失败的原因
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：成功；大于：失败的原因
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 825103;
	}
}