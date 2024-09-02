using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求添加玩家关系消息 message
 */
public class ReqAddRelationshipPlayerMessage : Message 
{
	//关系类型[0:黑名单]
	int _relationshipType;	
	//玩家编号
	long _playerId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//关系类型[0:黑名单]
		SerializeUtils.WriteInt(stream, _relationshipType);
		//玩家编号
		SerializeUtils.WriteLong(stream, _playerId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//关系类型[0:黑名单]
		_relationshipType = SerializeUtils.ReadInt(stream);
		//玩家编号
		_playerId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 关系类型[0:黑名单]
	 */
	public int RelationshipType
	{
		set { _relationshipType = value; }
	    get { return _relationshipType; }
	}
	
	/**
	 * 玩家编号
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	
	public override int GetId() 
	{
		return 223202;
	}
}