using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 被关系玩家该名消息 message
 */
public class ResRelationshipPlayerChangeNameMessage : Message 
{
	//被关系的玩家编号
	long _playerId;	
	//被关系的玩家最新名称
	string _playerName;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//被关系的玩家编号
		SerializeUtils.WriteLong(stream, _playerId);
		//被关系的玩家最新名称
		SerializeUtils.WriteString(stream, _playerName);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//被关系的玩家编号
		_playerId = SerializeUtils.ReadLong(stream);
		//被关系的玩家最新名称
		_playerName = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 被关系的玩家编号
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	/**
	 * 被关系的玩家最新名称
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	
	public override int GetId() 
	{
		return 223207;
	}
}