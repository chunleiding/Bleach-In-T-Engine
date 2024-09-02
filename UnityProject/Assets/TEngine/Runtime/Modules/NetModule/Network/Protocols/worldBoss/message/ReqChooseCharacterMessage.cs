using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求选择角色 message
 */
public class ReqChooseCharacterMessage : Message 
{
	//角色id
	int _characterID;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _characterID);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色id
		_characterID = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色id
	 */
	public int CharacterID
	{
		set { _characterID = value; }
	    get { return _characterID; }
	}
	
	
	public override int GetId() 
	{
		return 807108;
	}
}