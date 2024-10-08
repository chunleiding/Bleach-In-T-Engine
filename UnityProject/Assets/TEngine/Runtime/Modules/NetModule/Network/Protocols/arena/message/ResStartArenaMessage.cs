using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 竞技场对手列表 message
 */
public class ResStartArenaMessage : Message 
{
	//0：成功，1：等级不足，2：剩余次数不够，3：CD中
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功，1：等级不足，2：剩余次数不够，3：CD中
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功，1：等级不足，2：剩余次数不够，3：CD中
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：成功，1：等级不足，2：剩余次数不够，3：CD中
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 206103;
	}
}