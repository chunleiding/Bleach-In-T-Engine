using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复番队改名 message
 */
public class ResChangeGangNameMessage : Message 
{
	//0:成功，1：不是队长，没权限，2：名字不合法或者重复，3：改名道具不足
	int _result;	
	//新的番队名字
	string _gangName;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功，1：不是队长，没权限，2：名字不合法或者重复，3：改名道具不足
		SerializeUtils.WriteInt(stream, _result);
		//新的番队名字
		SerializeUtils.WriteString(stream, _gangName);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功，1：不是队长，没权限，2：名字不合法或者重复，3：改名道具不足
		_result = SerializeUtils.ReadInt(stream);
		//新的番队名字
		_gangName = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 0:成功，1：不是队长，没权限，2：名字不合法或者重复，3：改名道具不足
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 新的番队名字
	 */
	public string GangName
	{
		set { _gangName = value; }
	    get { return _gangName; }
	}
	
	
	public override int GetId() 
	{
		return 109143;
	}
}