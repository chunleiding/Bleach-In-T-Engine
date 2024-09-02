using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 给被关系的玩家发送消息 message
 */
public class ResRelationshipPlayerNoticeMessage : Message 
{
	//来至于哪个玩家编号
	long _fromPlayerId;	
	//关系类型[0:黑名单,1:好友]
	int _relationType;	
	//操作类型[1:增加关系,0:删除关系]
	int _relationControlType;	
	//来至于哪个玩家名称
	string _fromPlayerName;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//来至于哪个玩家编号
		SerializeUtils.WriteLong(stream, _fromPlayerId);
		//关系类型[0:黑名单,1:好友]
		SerializeUtils.WriteInt(stream, _relationType);
		//操作类型[1:增加关系,0:删除关系]
		SerializeUtils.WriteInt(stream, _relationControlType);
		//来至于哪个玩家名称
		SerializeUtils.WriteString(stream, _fromPlayerName);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//来至于哪个玩家编号
		_fromPlayerId = SerializeUtils.ReadLong(stream);
		//关系类型[0:黑名单,1:好友]
		_relationType = SerializeUtils.ReadInt(stream);
		//操作类型[1:增加关系,0:删除关系]
		_relationControlType = SerializeUtils.ReadInt(stream);
		//来至于哪个玩家名称
		_fromPlayerName = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 来至于哪个玩家编号
	 */
	public long FromPlayerId
	{
		set { _fromPlayerId = value; }
	    get { return _fromPlayerId; }
	}
	
	/**
	 * 关系类型[0:黑名单,1:好友]
	 */
	public int RelationType
	{
		set { _relationType = value; }
	    get { return _relationType; }
	}
	
	/**
	 * 操作类型[1:增加关系,0:删除关系]
	 */
	public int RelationControlType
	{
		set { _relationControlType = value; }
	    get { return _relationControlType; }
	}
	
	/**
	 * 来至于哪个玩家名称
	 */
	public string FromPlayerName
	{
		set { _fromPlayerName = value; }
	    get { return _fromPlayerName; }
	}
	
	
	public override int GetId() 
	{
		return 223205;
	}
}