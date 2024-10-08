using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动进度
 */
public class ActivityProgress : IMessageSerialize 
{
	//活动id
	int _id;	
	//进度值
	int _value;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//活动id
		SerializeUtils.WriteInt(stream, _id);
		//进度值
		SerializeUtils.WriteInt(stream, _value);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//活动id
		_id = SerializeUtils.ReadInt(stream);
		//进度值
		_value = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 活动id
	 */
	public int Id
	{
		set { _id = value; }
	    get { return _id; }
	}
	
	/**
	 * 进度值
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
}