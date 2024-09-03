using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 后端响应添加玩家关系消息 message
 */
public class ResAddRelationshipPlayerMessage : Message 
{
	//结果[0:成功,1:玩家不存在,2:玩家已经在玩家关系名单中,3:关系类型不存在,4:机器人不可以被加入玩家关系,5:玩家黑名单人数已达上限,6:不可以把自己加入玩家关系中]
	int _result;	
	//关系类型[0:黑名单]
	int _relationshipType;	
	//玩家关系
	RelationshipPlayer _player;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果[0:成功,1:玩家不存在,2:玩家已经在玩家关系名单中,3:关系类型不存在,4:机器人不可以被加入玩家关系,5:玩家黑名单人数已达上限,6:不可以把自己加入玩家关系中]
		SerializeUtils.WriteInt(stream, _result);
		//关系类型[0:黑名单]
		SerializeUtils.WriteInt(stream, _relationshipType);
		//玩家关系
		SerializeUtils.WriteBean(stream, _player);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果[0:成功,1:玩家不存在,2:玩家已经在玩家关系名单中,3:关系类型不存在,4:机器人不可以被加入玩家关系,5:玩家黑名单人数已达上限,6:不可以把自己加入玩家关系中]
		_result = SerializeUtils.ReadInt(stream);
		//关系类型[0:黑名单]
		_relationshipType = SerializeUtils.ReadInt(stream);
		//玩家关系
		_player = SerializeUtils.ReadBean<RelationshipPlayer>(stream);
	}
	
	/**
	 * 结果[0:成功,1:玩家不存在,2:玩家已经在玩家关系名单中,3:关系类型不存在,4:机器人不可以被加入玩家关系,5:玩家黑名单人数已达上限,6:不可以把自己加入玩家关系中]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
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
	 * 玩家关系
	 */
	public RelationshipPlayer Player
	{
		set { _player = value; }
	    get { return _player; }
	}
	
	
	public override int GetId() 
	{
		return 223102;
	}
}