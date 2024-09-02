using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色武器等级
 */
public class CharacterEquipInfo : IMessageSerialize 
{
	//角色ID
	int _characterId;	
	//武器信息
	List<EquipInfo> _equipInfoList = new List<EquipInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色ID
		SerializeUtils.WriteInt(stream, _characterId);
		//武器信息
		SerializeUtils.WriteShort(stream, (short)_equipInfoList.Count);

		foreach (var element in _equipInfoList)  
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
		//武器信息
		int _equipInfoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _equipInfoList_length; ++i) 
		{
			_equipInfoList.Add(SerializeUtils.ReadBean<EquipInfo>(stream));
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
	 * get 武器信息
	 * @return 
	 */
	public List<EquipInfo> GetEquipInfoList()
	{
		return _equipInfoList;
	}
	
	/**
	 * set 武器信息
	 */
	public void SetEquipInfoList(List<EquipInfo> equipInfoList)
	{
		_equipInfoList = equipInfoList;
	}
	
}