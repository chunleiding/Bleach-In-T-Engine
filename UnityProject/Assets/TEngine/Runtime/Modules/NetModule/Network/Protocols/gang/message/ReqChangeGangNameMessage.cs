using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求番队改名 message
 */
public class ReqChangeGangNameMessage : Message 
{
	//新的名字
	string _gangName;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//新的名字
		SerializeUtils.WriteString(stream, _gangName);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//新的名字
		_gangName = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 新的名字
	 */
	public string GangName
	{
		set { _gangName = value; }
	    get { return _gangName; }
	}
	
	
	public override int GetId() 
	{
		return 109231;
	}
}