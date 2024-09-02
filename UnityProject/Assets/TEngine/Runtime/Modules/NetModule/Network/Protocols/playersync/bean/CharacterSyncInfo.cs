using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步的角色信息
 */
public class CharacterSyncInfo : IMessageSerialize 
{
	//角色id
	int _characterId;	
	//角色阶级
	int _stageLevel;	
	//角色成长等级
	int _growthLevel;	
	//角色战斗力
	int _fighting;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//角色阶级
		SerializeUtils.WriteInt(stream, _stageLevel);
		//角色成长等级
		SerializeUtils.WriteInt(stream, _growthLevel);
		//角色战斗力
		SerializeUtils.WriteInt(stream, _fighting);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//角色阶级
		_stageLevel = SerializeUtils.ReadInt(stream);
		//角色成长等级
		_growthLevel = SerializeUtils.ReadInt(stream);
		//角色战斗力
		_fighting = SerializeUtils.ReadInt(stream);
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
	 * 角色阶级
	 */
	public int StageLevel
	{
		set { _stageLevel = value; }
	    get { return _stageLevel; }
	}
	
	/**
	 * 角色成长等级
	 */
	public int GrowthLevel
	{
		set { _growthLevel = value; }
	    get { return _growthLevel; }
	}
	
	/**
	 * 角色战斗力
	 */
	public int Fighting
	{
		set { _fighting = value; }
	    get { return _fighting; }
	}
	
}