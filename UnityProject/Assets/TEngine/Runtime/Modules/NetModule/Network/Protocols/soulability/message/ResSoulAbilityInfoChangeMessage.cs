using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回灵魂能力信息改变消息 message
 */
public class ResSoulAbilityInfoChangeMessage : Message 
{
	//角色id
	int _characterId;	
	//武器等级
	int _weaponLevel;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//武器等级
		SerializeUtils.WriteInt(stream, _weaponLevel);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//武器等级
		_weaponLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 武器等级
	 */
	public int WeaponLevel
	{
		set { _weaponLevel = value; }
	    get { return _weaponLevel; }
	}
	
	
	public override int GetId() 
	{
		return 304103;
	}
}