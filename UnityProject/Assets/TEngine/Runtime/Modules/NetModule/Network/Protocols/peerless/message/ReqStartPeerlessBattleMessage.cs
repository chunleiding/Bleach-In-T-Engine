using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求开始战斗消息 message
 */
public class ReqStartPeerlessBattleMessage : Message 
{
	//出战角色的id
	List<int> _characterIds = new List<int>();
	//队伍类型
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//出战角色的id
		SerializeUtils.WriteShort(stream, (short)_characterIds.Count);

		foreach (var element in _characterIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//队伍类型
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//出战角色的id
		int _characterIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterIds_length; ++i) 
		{
			_characterIds.Add(SerializeUtils.ReadInt(stream));
		}
		//队伍类型
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 出战角色的id
	 * @return 
	 */
	public List<int> GetCharacterIds()
	{
		return _characterIds;
	}
	
	/**
	 * set 出战角色的id
	 */
	public void SetCharacterIds(List<int> characterIds)
	{
		_characterIds = characterIds;
	}
	
	/**
	 * 队伍类型
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 817101;
	}
}