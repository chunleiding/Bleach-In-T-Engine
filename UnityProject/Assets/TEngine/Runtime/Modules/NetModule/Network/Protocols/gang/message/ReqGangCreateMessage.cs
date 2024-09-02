using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 创建番队 message
 */
public class ReqGangCreateMessage : Message 
{
	//名称
	string _name;	
	//旗帜id
	int _flag;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//名称
		SerializeUtils.WriteString(stream, _name);
		//旗帜id
		SerializeUtils.WriteInt(stream, _flag);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//名称
		_name = SerializeUtils.ReadString(stream);
		//旗帜id
		_flag = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 名称
	 */
	public string Name
	{
		set { _name = value; }
	    get { return _name; }
	}
	
	/**
	 * 旗帜id
	 */
	public int Flag
	{
		set { _flag = value; }
	    get { return _flag; }
	}
	
	
	public override int GetId() 
	{
		return 109201;
	}
}