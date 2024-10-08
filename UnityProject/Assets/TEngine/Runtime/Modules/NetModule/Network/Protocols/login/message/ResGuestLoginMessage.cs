using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 游客模式登陆 message
 */
public class ResGuestLoginMessage : Message 
{
	//账号名
	string _accountName;	
	//密码
	string _password;	
	//服务器id
	int _serverId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//账号名
		SerializeUtils.WriteString(stream, _accountName);
		//密码
		SerializeUtils.WriteString(stream, _password);
		//服务器id
		SerializeUtils.WriteInt(stream, _serverId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//账号名
		_accountName = SerializeUtils.ReadString(stream);
		//密码
		_password = SerializeUtils.ReadString(stream);
		//服务器id
		_serverId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 账号名
	 */
	public string AccountName
	{
		set { _accountName = value; }
	    get { return _accountName; }
	}
	
	/**
	 * 密码
	 */
	public string Password
	{
		set { _password = value; }
	    get { return _password; }
	}
	
	/**
	 * 服务器id
	 */
	public int ServerId
	{
		set { _serverId = value; }
	    get { return _serverId; }
	}
	
	
	public override int GetId() 
	{
		return 100106;
	}
}