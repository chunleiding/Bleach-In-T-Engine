using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 百万招财世界纪录
 */
public class MillionRecord : IMessageSerialize 
{
	//玩家名字
	string _playerName;	
	//招财记录
	int _million;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//玩家名字
		SerializeUtils.WriteString(stream, _playerName);
		//招财记录
		SerializeUtils.WriteInt(stream, _million);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//玩家名字
		_playerName = SerializeUtils.ReadString(stream);
		//招财记录
		_million = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 玩家名字
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * 招财记录
	 */
	public int Million
	{
		set { _million = value; }
	    get { return _million; }
	}
	
}