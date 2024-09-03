using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 商品购买前置条件
 */
public class RechargePreCondition : IMessageSerialize 
{
	//条件类型
	int _type;	
	//商品购买条件
	int _condition;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//条件类型
		SerializeUtils.WriteInt(stream, _type);
		//商品购买条件
		SerializeUtils.WriteInt(stream, _condition);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//条件类型
		_type = SerializeUtils.ReadInt(stream);
		//商品购买条件
		_condition = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 条件类型
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 商品购买条件
	 */
	public int Condition
	{
		set { _condition = value; }
	    get { return _condition; }
	}
	
}