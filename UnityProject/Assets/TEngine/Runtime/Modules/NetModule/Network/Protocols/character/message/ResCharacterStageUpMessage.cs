using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色进阶回复 message
 */
public class ResCharacterStageUpMessage : Message 
{
	//角色进阶结果(0:成功，1：元宝不足，
	byte _result;	
	//角色id
	int _characterId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色进阶结果(0:成功，1：元宝不足，
		SerializeUtils.WriteByte(stream, _result);
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色进阶结果(0:成功，1：元宝不足，
		_result = SerializeUtils.ReadByte(stream);
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色进阶结果(0:成功，1：元宝不足，
	 */
	public byte Result
	{
		set { _result = value; }
	    get { return _result; }
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
		return 200202;
	}
}