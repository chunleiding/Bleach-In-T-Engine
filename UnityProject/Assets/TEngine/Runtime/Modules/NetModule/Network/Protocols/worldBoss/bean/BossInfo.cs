using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * boss的基本信息
 */
public class BossInfo : IMessageSerialize 
{
	//boss编号
	int _ID;	
	//boss名字
	string _name;	
	//boss血量
	int _hp;	
	//Boss等级
	int _level;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//boss编号
		SerializeUtils.WriteInt(stream, _ID);
		//boss名字
		SerializeUtils.WriteString(stream, _name);
		//boss血量
		SerializeUtils.WriteInt(stream, _hp);
		//Boss等级
		SerializeUtils.WriteInt(stream, _level);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//boss编号
		_ID = SerializeUtils.ReadInt(stream);
		//boss名字
		_name = SerializeUtils.ReadString(stream);
		//boss血量
		_hp = SerializeUtils.ReadInt(stream);
		//Boss等级
		_level = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * boss编号
	 */
	public int ID
	{
		set { _ID = value; }
	    get { return _ID; }
	}
	
	/**
	 * boss名字
	 */
	public string Name
	{
		set { _name = value; }
	    get { return _name; }
	}
	
	/**
	 * boss血量
	 */
	public int Hp
	{
		set { _hp = value; }
	    get { return _hp; }
	}
	
	/**
	 * Boss等级
	 */
	public int Level
	{
		set { _level = value; }
	    get { return _level; }
	}
	
}