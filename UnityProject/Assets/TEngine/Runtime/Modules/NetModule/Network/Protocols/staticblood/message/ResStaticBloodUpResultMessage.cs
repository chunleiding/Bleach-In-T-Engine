using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 静血装升级结果 message
 */
public class ResStaticBloodUpResultMessage : Message 
{
	//升级结果[0:成功; 1:系统未开放;2:已达到最高等级; 3:升级所需材料不足]
	int _result;	
	//角色id
	int _characterId;	
	//静血装id
	int _staticBloodId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//升级结果[0:成功; 1:系统未开放;2:已达到最高等级; 3:升级所需材料不足]
		SerializeUtils.WriteInt(stream, _result);
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//静血装id
		SerializeUtils.WriteInt(stream, _staticBloodId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//升级结果[0:成功; 1:系统未开放;2:已达到最高等级; 3:升级所需材料不足]
		_result = SerializeUtils.ReadInt(stream);
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//静血装id
		_staticBloodId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 升级结果[0:成功; 1:系统未开放;2:已达到最高等级; 3:升级所需材料不足]
	 */
	public int Result
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
	
	/**
	 * 静血装id
	 */
	public int StaticBloodId
	{
		set { _staticBloodId = value; }
	    get { return _staticBloodId; }
	}
	
	
	public override int GetId() 
	{
		return 812102;
	}
}