using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 加速回复 message
 */
public class ResSpeedUpMessage : Message 
{
	//0 成功 其他失败
	int _success;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0 成功 其他失败
		SerializeUtils.WriteInt(stream, _success);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0 成功 其他失败
		_success = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0 成功 其他失败
	 */
	public int Success
	{
		set { _success = value; }
	    get { return _success; }
	}
	
	
	public override int GetId() 
	{
		return 810101;
	}
}