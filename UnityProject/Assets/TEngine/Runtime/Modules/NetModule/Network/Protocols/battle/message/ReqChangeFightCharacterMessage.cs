using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 更换战斗角色请求 message
 */
public class ReqChangeFightCharacterMessage : Message 
{
	//出战角色id
	int _characterId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//出战角色id
		SerializeUtils.WriteInt(stream, _characterId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//出战角色id
		_characterId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 出战角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	
	public override int GetId() 
	{
		return 400101;
	}
}