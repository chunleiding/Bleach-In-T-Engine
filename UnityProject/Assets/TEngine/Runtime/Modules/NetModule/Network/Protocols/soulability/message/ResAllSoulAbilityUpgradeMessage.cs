using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一键升级所有角色全体鬼道返回 message
 */
public class ResAllSoulAbilityUpgradeMessage : Message 
{
	//结果（1：成功，2：灵子不足，3：技能点不足，4：魂玉不足）
	int _result;	
	//角色鬼道信息列表
	List<CharacterSoulAbilityInfo> _characterSoulAbilityInfoList = new List<CharacterSoulAbilityInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果（1：成功，2：灵子不足，3：技能点不足，4：魂玉不足）
		SerializeUtils.WriteInt(stream, _result);
		//角色鬼道信息列表
		SerializeUtils.WriteShort(stream, (short)_characterSoulAbilityInfoList.Count);

		foreach (var element in _characterSoulAbilityInfoList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果（1：成功，2：灵子不足，3：技能点不足，4：魂玉不足）
		_result = SerializeUtils.ReadInt(stream);
		//角色鬼道信息列表
		int _characterSoulAbilityInfoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterSoulAbilityInfoList_length; ++i) 
		{
			_characterSoulAbilityInfoList.Add(SerializeUtils.ReadBean<CharacterSoulAbilityInfo>(stream));
		}
	}
	
	/**
	 * 结果（1：成功，2：灵子不足，3：技能点不足，4：魂玉不足）
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * get 角色鬼道信息列表
	 * @return 
	 */
	public List<CharacterSoulAbilityInfo> GetCharacterSoulAbilityInfoList()
	{
		return _characterSoulAbilityInfoList;
	}
	
	/**
	 * set 角色鬼道信息列表
	 */
	public void SetCharacterSoulAbilityInfoList(List<CharacterSoulAbilityInfo> characterSoulAbilityInfoList)
	{
		_characterSoulAbilityInfoList = characterSoulAbilityInfoList;
	}
	
	
	public override int GetId() 
	{
		return 304302;
	}
}