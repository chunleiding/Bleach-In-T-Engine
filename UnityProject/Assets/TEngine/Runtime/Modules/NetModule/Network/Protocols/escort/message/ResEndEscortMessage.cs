using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 结束护送战斗 message
 */
public class ResEndEscortMessage : Message 
{
	//结果0：成功
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果0：成功
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果0：成功
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 结果0：成功
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 810120;
	}
}