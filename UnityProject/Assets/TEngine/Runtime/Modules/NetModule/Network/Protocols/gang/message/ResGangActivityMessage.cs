using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活跃度 message
 */
public class ResGangActivityMessage : Message 
{
	//番队成员的当前值
	int _value;	
	//番队的当前值
	int _gangValue;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队成员的当前值
		SerializeUtils.WriteInt(stream, _value);
		//番队的当前值
		SerializeUtils.WriteInt(stream, _gangValue);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队成员的当前值
		_value = SerializeUtils.ReadInt(stream);
		//番队的当前值
		_gangValue = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 番队成员的当前值
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
	/**
	 * 番队的当前值
	 */
	public int GangValue
	{
		set { _gangValue = value; }
	    get { return _gangValue; }
	}
	
	
	public override int GetId() 
	{
		return 109108;
	}
}