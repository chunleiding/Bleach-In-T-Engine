using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一键升级单个角色武器到突破点 message
 */
public class ReqOneEquipLevelUpMessage : Message 
{
	//角色Id
	int _characterId;	
	//武器ID
	int _equipeId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色Id
		SerializeUtils.WriteInt(stream, _characterId);
		//武器ID
		SerializeUtils.WriteInt(stream, _equipeId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色Id
		_characterId = SerializeUtils.ReadInt(stream);
		//武器ID
		_equipeId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色Id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 武器ID
	 */
	public int EquipeId
	{
		set { _equipeId = value; }
	    get { return _equipeId; }
	}
	
	
	public override int GetId() 
	{
		return 103204;
	}
}