using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复清除换一批倒计时 message
 */
public class ResClearChageTimeMessage : Message 
{
	//0,换一批，1护送时间
	int _type;	
	//0成功 其他失败
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0,换一批，1护送时间
		SerializeUtils.WriteInt(stream, _type);
		//0成功 其他失败
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0,换一批，1护送时间
		_type = SerializeUtils.ReadInt(stream);
		//0成功 其他失败
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0,换一批，1护送时间
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 0成功 其他失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 810105;
	}
}