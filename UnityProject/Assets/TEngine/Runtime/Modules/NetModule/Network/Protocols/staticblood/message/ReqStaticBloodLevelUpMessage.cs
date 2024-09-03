using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求静血装升级 message
 */
public class ReqStaticBloodLevelUpMessage : Message 
{
	//角色id
	int _characterId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	
	public override int GetId() 
	{
		return 812100;
	}
}