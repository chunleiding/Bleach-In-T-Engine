using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 建设信息
 */
public class BuildInfo : IMessageSerialize 
{
	//建设编号
	int _id;	
	//建设等级
	int _level;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//建设编号
		SerializeUtils.WriteInt(stream, _id);
		//建设等级
		SerializeUtils.WriteInt(stream, _level);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//建设编号
		_id = SerializeUtils.ReadInt(stream);
		//建设等级
		_level = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 建设编号
	 */
	public int Id
	{
		set { _id = value; }
	    get { return _id; }
	}
	
	/**
	 * 建设等级
	 */
	public int Level
	{
		set { _level = value; }
	    get { return _level; }
	}
	
}