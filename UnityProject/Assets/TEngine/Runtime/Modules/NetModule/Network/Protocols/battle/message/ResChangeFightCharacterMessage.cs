using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家战斗属性同步 message
 */
public class ResChangeFightCharacterMessage : Message 
{
	//0：成功，1-无此角色，2-角色不可用
	int _result;	
	//战斗属性
	CharacterAttributeInfo _characterAttributeInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功，1-无此角色，2-角色不可用
		SerializeUtils.WriteInt(stream, _result);
		//战斗属性
		SerializeUtils.WriteBean(stream, _characterAttributeInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功，1-无此角色，2-角色不可用
		_result = SerializeUtils.ReadInt(stream);
		//战斗属性
		_characterAttributeInfo = SerializeUtils.ReadBean<CharacterAttributeInfo>(stream);
	}
	
	/**
	 * 0：成功，1-无此角色，2-角色不可用
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 战斗属性
	 */
	public CharacterAttributeInfo CharacterAttributeInfo
	{
		set { _characterAttributeInfo = value; }
	    get { return _characterAttributeInfo; }
	}
	
	
	public override int GetId() 
	{
		return 400205;
	}
}