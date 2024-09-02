using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 手机号注册成功消息 message
 */
public class ReqPhoneRegSuccessMessage : Message 
{
	//手机号码
	string _phoneNum;	
	//新的Uid
	string _newUid;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//手机号码
		SerializeUtils.WriteString(stream, _phoneNum);
		//新的Uid
		SerializeUtils.WriteString(stream, _newUid);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//手机号码
		_phoneNum = SerializeUtils.ReadString(stream);
		//新的Uid
		_newUid = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 手机号码
	 */
	public string PhoneNum
	{
		set { _phoneNum = value; }
	    get { return _phoneNum; }
	}
	
	/**
	 * 新的Uid
	 */
	public string NewUid
	{
		set { _newUid = value; }
	    get { return _newUid; }
	}
	
	
	public override int GetId() 
	{
		return 100207;
	}
}