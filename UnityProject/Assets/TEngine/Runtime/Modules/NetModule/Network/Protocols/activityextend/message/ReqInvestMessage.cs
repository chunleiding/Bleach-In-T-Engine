using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 投资活动消息 message
 */
public class ReqInvestMessage : Message 
{
	//投资值
	int _value;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//投资值
		SerializeUtils.WriteInt(stream, _value);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//投资值
		_value = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 投资值
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
	
	public override int GetId() 
	{
		return 823112;
	}
}