using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求换人 message
 */
public class ReqExploreChangeActorMessage : Message 
{
	//玩家所选角色列表
	List<int> _characterList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家所选角色列表
		SerializeUtils.WriteShort(stream, (short)_characterList.Count);

		foreach (var element in _characterList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家所选角色列表
		int _characterList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterList_length; ++i) 
		{
			_characterList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 玩家所选角色列表
	 * @return 
	 */
	public List<int> GetCharacterList()
	{
		return _characterList;
	}
	
	/**
	 * set 玩家所选角色列表
	 */
	public void SetCharacterList(List<int> characterList)
	{
		_characterList = characterList;
	}
	
	
	public override int GetId() 
	{
		return 831104;
	}
}