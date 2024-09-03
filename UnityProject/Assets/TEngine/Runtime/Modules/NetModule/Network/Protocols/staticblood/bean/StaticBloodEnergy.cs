using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 静血装能量值
 */
public class StaticBloodEnergy : IMessageSerialize 
{
	//静血装能量因素key
	int _key;	
	//能量值
	int _value;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//静血装能量因素key
		SerializeUtils.WriteInt(stream, _key);
		//能量值
		SerializeUtils.WriteInt(stream, _value);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//静血装能量因素key
		_key = SerializeUtils.ReadInt(stream);
		//能量值
		_value = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 静血装能量因素key
	 */
	public int Key
	{
		set { _key = value; }
	    get { return _key; }
	}
	
	/**
	 * 能量值
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
}