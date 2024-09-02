using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一键升级单个角色武器到突破点返回 message
 */
public class ResOneEquipLevelUpMessage : Message 
{
	//结果（1：成功，0灵子不足）
	int _result;	
	//角色武器信息
	CharacterEquipInfo _characterEquipInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果（1：成功，0灵子不足）
		SerializeUtils.WriteInt(stream, _result);
		//角色武器信息
		SerializeUtils.WriteBean(stream, _characterEquipInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果（1：成功，0灵子不足）
		_result = SerializeUtils.ReadInt(stream);
		//角色武器信息
		_characterEquipInfo = SerializeUtils.ReadBean<CharacterEquipInfo>(stream);
	}
	
	/**
	 * 结果（1：成功，0灵子不足）
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 角色武器信息
	 */
	public CharacterEquipInfo CharacterEquipInfo
	{
		set { _characterEquipInfo = value; }
	    get { return _characterEquipInfo; }
	}
	
	
	public override int GetId() 
	{
		return 103205;
	}
}