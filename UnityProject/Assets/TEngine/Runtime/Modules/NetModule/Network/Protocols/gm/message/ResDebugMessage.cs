using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端调试内部消息 message
 */
public class ResDebugMessage : Message 
{
	//主CDN
	string _cdn1;	
	//备用CDN
	string _cdn2;	
	//服务器列表地址
	string _serverlistUrl;	
	//客户端版本号
	string _gameVersion;	
	//是否开启调试，0:开启,1:关闭
	int _debug;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//主CDN
		SerializeUtils.WriteString(stream, _cdn1);
		//备用CDN
		SerializeUtils.WriteString(stream, _cdn2);
		//服务器列表地址
		SerializeUtils.WriteString(stream, _serverlistUrl);
		//客户端版本号
		SerializeUtils.WriteString(stream, _gameVersion);
		//是否开启调试，0:开启,1:关闭
		SerializeUtils.WriteInt(stream, _debug);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//主CDN
		_cdn1 = SerializeUtils.ReadString(stream);
		//备用CDN
		_cdn2 = SerializeUtils.ReadString(stream);
		//服务器列表地址
		_serverlistUrl = SerializeUtils.ReadString(stream);
		//客户端版本号
		_gameVersion = SerializeUtils.ReadString(stream);
		//是否开启调试，0:开启,1:关闭
		_debug = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 主CDN
	 */
	public string Cdn1
	{
		set { _cdn1 = value; }
	    get { return _cdn1; }
	}
	
	/**
	 * 备用CDN
	 */
	public string Cdn2
	{
		set { _cdn2 = value; }
	    get { return _cdn2; }
	}
	
	/**
	 * 服务器列表地址
	 */
	public string ServerlistUrl
	{
		set { _serverlistUrl = value; }
	    get { return _serverlistUrl; }
	}
	
	/**
	 * 客户端版本号
	 */
	public string GameVersion
	{
		set { _gameVersion = value; }
	    get { return _gameVersion; }
	}
	
	/**
	 * 是否开启调试，0:开启,1:关闭
	 */
	public int Debug
	{
		set { _debug = value; }
	    get { return _debug; }
	}
	
	
	public override int GetId() 
	{
		return 308202;
	}
}