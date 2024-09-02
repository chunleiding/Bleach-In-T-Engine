using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 世界boos结束上层消息 message
 */
public class ResEndWorldBossMessage : Message 
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
		return 807116;
	}
}