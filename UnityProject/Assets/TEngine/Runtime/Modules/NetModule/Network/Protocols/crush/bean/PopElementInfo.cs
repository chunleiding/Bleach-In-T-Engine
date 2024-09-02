using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 消消乐元素信息
 */
public class PopElementInfo : IMessageSerialize 
{
	//索引坐标
	int _index;	
	//元素值
	int _value;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//索引坐标
		SerializeUtils.WriteInt(stream, _index);
		//元素值
		SerializeUtils.WriteInt(stream, _value);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//索引坐标
		_index = SerializeUtils.ReadInt(stream);
		//元素值
		_value = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 索引坐标
	 */
	public int Index
	{
		set { _index = value; }
	    get { return _index; }
	}
	
	/**
	 * 元素值
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
}