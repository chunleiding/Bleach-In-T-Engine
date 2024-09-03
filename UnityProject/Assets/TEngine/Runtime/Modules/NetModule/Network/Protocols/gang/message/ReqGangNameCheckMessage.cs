using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队名称验证 message
 */
public class ReqGangNameCheckMessage : Message 
{
	//名称
	string _name;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//名称
		SerializeUtils.WriteString(stream, _name);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//名称
		_name = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 名称
	 */
	public string Name
	{
		set { _name = value; }
	    get { return _name; }
	}
	
	
	public override int GetId() 
	{
		return 109220;
	}
}