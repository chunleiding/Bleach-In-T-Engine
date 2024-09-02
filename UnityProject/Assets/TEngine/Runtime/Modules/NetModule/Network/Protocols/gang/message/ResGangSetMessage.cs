using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队设置 message
 */
public class ResGangSetMessage : Message 
{
	//0:不需验证 1:需要验证
	byte _type;	
	//等级要求
	int _level;	
	//旗帜
	int _flag;	
	//队训
	string _notice;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:不需验证 1:需要验证
		SerializeUtils.WriteByte(stream, _type);
		//等级要求
		SerializeUtils.WriteInt(stream, _level);
		//旗帜
		SerializeUtils.WriteInt(stream, _flag);
		//队训
		SerializeUtils.WriteString(stream, _notice);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:不需验证 1:需要验证
		_type = SerializeUtils.ReadByte(stream);
		//等级要求
		_level = SerializeUtils.ReadInt(stream);
		//旗帜
		_flag = SerializeUtils.ReadInt(stream);
		//队训
		_notice = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 0:不需验证 1:需要验证
	 */
	public byte Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 等级要求
	 */
	public int Level
	{
		set { _level = value; }
	    get { return _level; }
	}
	
	/**
	 * 旗帜
	 */
	public int Flag
	{
		set { _flag = value; }
	    get { return _flag; }
	}
	
	/**
	 * 队训
	 */
	public string Notice
	{
		set { _notice = value; }
	    get { return _notice; }
	}
	
	
	public override int GetId() 
	{
		return 109113;
	}
}