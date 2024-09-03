using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求开始护送战斗 message
 */
public class ReqStartEscortFightMessage : Message 
{
	//对手玩家id
	long _enemyPlayerId;	
	//使用的角色的id
	List<int> _characterIds = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//对手玩家id
		SerializeUtils.WriteLong(stream, _enemyPlayerId);
		//使用的角色的id
		SerializeUtils.WriteShort(stream, (short)_characterIds.Count);

		foreach (var element in _characterIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//对手玩家id
		_enemyPlayerId = SerializeUtils.ReadLong(stream);
		//使用的角色的id
		int _characterIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterIds_length; ++i) 
		{
			_characterIds.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 对手玩家id
	 */
	public long EnemyPlayerId
	{
		set { _enemyPlayerId = value; }
	    get { return _enemyPlayerId; }
	}
	
	/**
	 * get 使用的角色的id
	 * @return 
	 */
	public List<int> GetCharacterIds()
	{
		return _characterIds;
	}
	
	/**
	 * set 使用的角色的id
	 */
	public void SetCharacterIds(List<int> characterIds)
	{
		_characterIds = characterIds;
	}
	
	
	public override int GetId() 
	{
		return 810121;
	}
}