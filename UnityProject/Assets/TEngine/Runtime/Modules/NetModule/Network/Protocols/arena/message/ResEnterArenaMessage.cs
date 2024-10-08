using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 进入竞技场回复 message
 */
public class ResEnterArenaMessage : Message 
{
	//0：成功，1：等级不足
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功，1：等级不足
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功，1：等级不足
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：成功，1：等级不足
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 206101;
	}
}