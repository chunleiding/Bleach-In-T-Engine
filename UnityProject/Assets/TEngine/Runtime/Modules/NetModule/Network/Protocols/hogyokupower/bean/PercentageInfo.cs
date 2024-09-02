using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色总星数对应提升的百分比
 */
public class PercentageInfo : IMessageSerialize 
{
	//角色总星数
	int _starNum;	
	//对应提升属性百分比
	int _percent;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色总星数
		SerializeUtils.WriteInt(stream, _starNum);
		//对应提升属性百分比
		SerializeUtils.WriteInt(stream, _percent);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色总星数
		_starNum = SerializeUtils.ReadInt(stream);
		//对应提升属性百分比
		_percent = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色总星数
	 */
	public int StarNum
	{
		set { _starNum = value; }
	    get { return _starNum; }
	}
	
	/**
	 * 对应提升属性百分比
	 */
	public int Percent
	{
		set { _percent = value; }
	    get { return _percent; }
	}
	
}