using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色id->角色伤害
 */
public class WorldBossFightData : IMessageSerialize 
{
	//角色id
	int _charactorId;	
	//伤害
	int _damage;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _charactorId);
		//伤害
		SerializeUtils.WriteInt(stream, _damage);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色id
		_charactorId = SerializeUtils.ReadInt(stream);
		//伤害
		_damage = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色id
	 */
	public int CharactorId
	{
		set { _charactorId = value; }
	    get { return _charactorId; }
	}
	
	/**
	 * 伤害
	 */
	public int Damage
	{
		set { _damage = value; }
	    get { return _damage; }
	}
	
}