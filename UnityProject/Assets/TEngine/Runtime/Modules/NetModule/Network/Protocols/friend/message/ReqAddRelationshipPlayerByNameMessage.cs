using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 根据用户名添加关系 message
 */
public class ReqAddRelationshipPlayerByNameMessage : Message 
{
	//关系类型[0:黑名单,1:好友]
	int _relationType;	
	//玩家名称
	string _playerName;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//关系类型[0:黑名单,1:好友]
		SerializeUtils.WriteInt(stream, _relationType);
		//玩家名称
		SerializeUtils.WriteString(stream, _playerName);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//关系类型[0:黑名单,1:好友]
		_relationType = SerializeUtils.ReadInt(stream);
		//玩家名称
		_playerName = SerializeUtils.ReadString(stream);
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
	 * 玩家名称
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	
	public override int GetId() 
	{
		return 223206;
	}
}