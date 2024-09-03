using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色鬼道信息
 */
public class CharacterSoulAbilityInfo : IMessageSerialize 
{
	//角色ID
	int _characterId;	
	//鬼道信息
	List<SoulAbilityInfo> _SoulAbilityInfoList = new List<SoulAbilityInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色ID
		SerializeUtils.WriteInt(stream, _characterId);
		//鬼道信息
		SerializeUtils.WriteShort(stream, (short)_SoulAbilityInfoList.Count);

		foreach (var element in _SoulAbilityInfoList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色ID
		_characterId = SerializeUtils.ReadInt(stream);
		//鬼道信息
		int _SoulAbilityInfoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _SoulAbilityInfoList_length; ++i) 
		{
			_SoulAbilityInfoList.Add(SerializeUtils.ReadBean<SoulAbilityInfo>(stream));
		}
	}
	
	/**
	 * 角色ID
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * get 鬼道信息
	 * @return 
	 */
	public List<SoulAbilityInfo> GetSoulAbilityInfoList()
	{
		return _SoulAbilityInfoList;
	}
	
	/**
	 * set 鬼道信息
	 */
	public void SetSoulAbilityInfoList(List<SoulAbilityInfo> SoulAbilityInfoList)
	{
		_SoulAbilityInfoList = SoulAbilityInfoList;
	}
	
}