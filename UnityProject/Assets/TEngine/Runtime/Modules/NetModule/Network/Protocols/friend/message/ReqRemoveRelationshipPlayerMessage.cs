using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求移除玩家关系消息 message
 */
public class ReqRemoveRelationshipPlayerMessage : Message 
{
	//关系类型[0:黑名单]
	int _relationshipType;	
	//玩家编号列表[列表为空:全部删除,列表不为空:删除列表里面的玩家]
	List<long> _playerId = new List<long>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//关系类型[0:黑名单]
		SerializeUtils.WriteInt(stream, _relationshipType);
		//玩家编号列表[列表为空:全部删除,列表不为空:删除列表里面的玩家]
		SerializeUtils.WriteShort(stream, (short)_playerId.Count);

		foreach (var element in _playerId)  
		{
			SerializeUtils.WriteLong(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//关系类型[0:黑名单]
		_relationshipType = SerializeUtils.ReadInt(stream);
		//玩家编号列表[列表为空:全部删除,列表不为空:删除列表里面的玩家]
		int _playerId_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _playerId_length; ++i) 
		{
			_playerId.Add(SerializeUtils.ReadLong(stream));
		}
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
	 * get 玩家编号列表[列表为空:全部删除,列表不为空:删除列表里面的玩家]
	 * @return 
	 */
	public List<long> GetPlayerId()
	{
		return _playerId;
	}
	
	/**
	 * set 玩家编号列表[列表为空:全部删除,列表不为空:删除列表里面的玩家]
	 */
	public void SetPlayerId(List<long> playerId)
	{
		_playerId = playerId;
	}
	
	
	public override int GetId() 
	{
		return 223203;
	}
}