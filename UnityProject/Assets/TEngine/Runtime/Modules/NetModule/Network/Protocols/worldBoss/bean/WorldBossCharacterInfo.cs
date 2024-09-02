using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色血量
 */
public class WorldBossCharacterInfo : IMessageSerialize 
{
	//世界boss角色id
	int _characterId;	
	//世界boss角色剩余血量
	int _characterHp;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//世界boss角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//世界boss角色剩余血量
		SerializeUtils.WriteInt(stream, _characterHp);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//世界boss角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//世界boss角色剩余血量
		_characterHp = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 世界boss角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 世界boss角色剩余血量
	 */
	public int CharacterHp
	{
		set { _characterHp = value; }
	    get { return _characterHp; }
	}
	
}