using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回灵魂能力激活结果消息 message
 */
public class ResSoulAbilityActivateMessage : Message 
{
	//灵魂能力升级结果消息id（0：成功，非0：失败的消息id）
	int _msg;	
	//角色id
	int _characterId;	
	//灵魂能力id
	int _soulabilityId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//灵魂能力升级结果消息id（0：成功，非0：失败的消息id）
		SerializeUtils.WriteInt(stream, _msg);
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//灵魂能力id
		SerializeUtils.WriteInt(stream, _soulabilityId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//灵魂能力升级结果消息id（0：成功，非0：失败的消息id）
		_msg = SerializeUtils.ReadInt(stream);
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//灵魂能力id
		_soulabilityId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 灵魂能力升级结果消息id（0：成功，非0：失败的消息id）
	 */
	public int Msg
	{
		set { _msg = value; }
	    get { return _msg; }
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
	 * 灵魂能力id
	 */
	public int SoulabilityId
	{
		set { _soulabilityId = value; }
	    get { return _soulabilityId; }
	}
	
	
	public override int GetId() 
	{
		return 304102;
	}
}