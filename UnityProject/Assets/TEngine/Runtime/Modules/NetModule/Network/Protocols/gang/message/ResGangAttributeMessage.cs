using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应刷新番队建设奖励状态消息 message
 */
public class ResGangAttributeMessage : Message 
{
	//属性类型[0:番队经验值,1:番队点数]
	int _attributeType;	
	//属性值
	int _value;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//属性类型[0:番队经验值,1:番队点数]
		SerializeUtils.WriteInt(stream, _attributeType);
		//属性值
		SerializeUtils.WriteInt(stream, _value);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//属性类型[0:番队经验值,1:番队点数]
		_attributeType = SerializeUtils.ReadInt(stream);
		//属性值
		_value = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 属性类型[0:番队经验值,1:番队点数]
	 */
	public int AttributeType
	{
		set { _attributeType = value; }
	    get { return _attributeType; }
	}
	
	/**
	 * 属性值
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
	
	public override int GetId() 
	{
		return 109157;
	}
}