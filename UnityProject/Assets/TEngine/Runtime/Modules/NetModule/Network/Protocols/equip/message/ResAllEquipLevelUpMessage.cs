using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一键升级所有角色武器到突破点返回 message
 */
public class ResAllEquipLevelUpMessage : Message 
{
	//结果，1：成功，0：灵子不足
	int _result;	
	//角色武器信息列表
	List<CharacterEquipInfo> _characterEquipInfoList = new List<CharacterEquipInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果，1：成功，0：灵子不足
		SerializeUtils.WriteInt(stream, _result);
		//角色武器信息列表
		SerializeUtils.WriteShort(stream, (short)_characterEquipInfoList.Count);

		foreach (var element in _characterEquipInfoList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果，1：成功，0：灵子不足
		_result = SerializeUtils.ReadInt(stream);
		//角色武器信息列表
		int _characterEquipInfoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterEquipInfoList_length; ++i) 
		{
			_characterEquipInfoList.Add(SerializeUtils.ReadBean<CharacterEquipInfo>(stream));
		}
	}
	
	/**
	 * 结果，1：成功，0：灵子不足
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * get 角色武器信息列表
	 * @return 
	 */
	public List<CharacterEquipInfo> GetCharacterEquipInfoList()
	{
		return _characterEquipInfoList;
	}
	
	/**
	 * set 角色武器信息列表
	 */
	public void SetCharacterEquipInfoList(List<CharacterEquipInfo> characterEquipInfoList)
	{
		_characterEquipInfoList = characterEquipInfoList;
	}
	
	
	public override int GetId() 
	{
		return 103203;
	}
}