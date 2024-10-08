using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战报名回复 message
 */
public class ResGangBattleApplyMessage : Message 
{
	//0：成功，1：已报名，2：不在报名期，3：参战角色错误，4：魂共鸣错误
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功，1：已报名，2：不在报名期，3：参战角色错误，4：魂共鸣错误
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功，1：已报名，2：不在报名期，3：参战角色错误，4：魂共鸣错误
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：成功，1：已报名，2：不在报名期，3：参战角色错误，4：魂共鸣错误
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 112101;
	}
}