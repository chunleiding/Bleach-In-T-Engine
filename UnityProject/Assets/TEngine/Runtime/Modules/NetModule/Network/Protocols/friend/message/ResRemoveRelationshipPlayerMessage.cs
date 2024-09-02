using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 后端响应移除玩家关系消息 message
 */
public class ResRemoveRelationshipPlayerMessage : Message 
{
	//结果[0:成功,1:玩家不存在,2:玩家不在玩家关系名单中,3:关系类型不存在,4:玩家关系名单中没有数据]
	int _result;	
	//关系类型[0:黑名单]
	int _relationshipType;	
	//玩家编号列表
	List<long> _playerId = new List<long>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果[0:成功,1:玩家不存在,2:玩家不在玩家关系名单中,3:关系类型不存在,4:玩家关系名单中没有数据]
		SerializeUtils.WriteInt(stream, _result);
		//关系类型[0:黑名单]
		SerializeUtils.WriteInt(stream, _relationshipType);
		//玩家编号列表
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
		//结果[0:成功,1:玩家不存在,2:玩家不在玩家关系名单中,3:关系类型不存在,4:玩家关系名单中没有数据]
		_result = SerializeUtils.ReadInt(stream);
		//关系类型[0:黑名单]
		_relationshipType = SerializeUtils.ReadInt(stream);
		//玩家编号列表
		int _playerId_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _playerId_length; ++i) 
		{
			_playerId.Add(SerializeUtils.ReadLong(stream));
		}
	}
	
	/**
	 * 结果[0:成功,1:玩家不存在,2:玩家不在玩家关系名单中,3:关系类型不存在,4:玩家关系名单中没有数据]
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
	 * get 玩家编号列表
	 * @return 
	 */
	public List<long> GetPlayerId()
	{
		return _playerId;
	}
	
	/**
	 * set 玩家编号列表
	 */
	public void SetPlayerId(List<long> playerId)
	{
		_playerId = playerId;
	}
	
	
	public override int GetId() 
	{
		return 223103;
	}
}