using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求开始战斗 message
 */
public class ReqStartExploreFightMessage : Message 
{
	//使用的角色的id
	List<int> _characterIds = new List<int>();
	//挑战的关卡ID
	int _fightLevelId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//使用的角色的id
		SerializeUtils.WriteShort(stream, (short)_characterIds.Count);

		foreach (var element in _characterIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//挑战的关卡ID
		SerializeUtils.WriteInt(stream, _fightLevelId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//使用的角色的id
		int _characterIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterIds_length; ++i) 
		{
			_characterIds.Add(SerializeUtils.ReadInt(stream));
		}
		//挑战的关卡ID
		_fightLevelId = SerializeUtils.ReadInt(stream);
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
	
	/**
	 * 挑战的关卡ID
	 */
	public int FightLevelId
	{
		set { _fightLevelId = value; }
	    get { return _fightLevelId; }
	}
	
	
	public override int GetId() 
	{
		return 831115;
	}
}