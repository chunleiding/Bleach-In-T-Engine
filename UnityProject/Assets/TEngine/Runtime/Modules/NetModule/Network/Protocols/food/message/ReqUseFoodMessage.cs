using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求对当前烹制出的普通料理操作方式消息 message
 */
public class ReqUseFoodMessage : Message 
{
	//操作[0:吃,1:放弃]
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//操作[0:吃,1:放弃]
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//操作[0:吃,1:放弃]
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 操作[0:吃,1:放弃]
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 106203;
	}
}