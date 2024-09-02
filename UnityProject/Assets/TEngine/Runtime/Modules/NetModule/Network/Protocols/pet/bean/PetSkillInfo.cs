using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 当前玩家技能数据
 */
public class PetSkillInfo : IMessageSerialize 
{
	//技能id
	int _skillId;	
	//当前玩家技能使用状态 0没激活 1启用 2卸下
	int _state;	
	//技能激活所需宠物等级
	int _activateLevel;	
	//技能升至下级所需宠物等级
	int _updateLevel;	
	//技能等级
	int _skillLevel;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//技能id
		SerializeUtils.WriteInt(stream, _skillId);
		//当前玩家技能使用状态 0没激活 1启用 2卸下
		SerializeUtils.WriteInt(stream, _state);
		//技能激活所需宠物等级
		SerializeUtils.WriteInt(stream, _activateLevel);
		//技能升至下级所需宠物等级
		SerializeUtils.WriteInt(stream, _updateLevel);
		//技能等级
		SerializeUtils.WriteInt(stream, _skillLevel);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//技能id
		_skillId = SerializeUtils.ReadInt(stream);
		//当前玩家技能使用状态 0没激活 1启用 2卸下
		_state = SerializeUtils.ReadInt(stream);
		//技能激活所需宠物等级
		_activateLevel = SerializeUtils.ReadInt(stream);
		//技能升至下级所需宠物等级
		_updateLevel = SerializeUtils.ReadInt(stream);
		//技能等级
		_skillLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 技能id
	 */
	public int SkillId
	{
		set { _skillId = value; }
	    get { return _skillId; }
	}
	
	/**
	 * 当前玩家技能使用状态 0没激活 1启用 2卸下
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	/**
	 * 技能激活所需宠物等级
	 */
	public int ActivateLevel
	{
		set { _activateLevel = value; }
	    get { return _activateLevel; }
	}
	
	/**
	 * 技能升至下级所需宠物等级
	 */
	public int UpdateLevel
	{
		set { _updateLevel = value; }
	    get { return _updateLevel; }
	}
	
	/**
	 * 技能等级
	 */
	public int SkillLevel
	{
		set { _skillLevel = value; }
	    get { return _skillLevel; }
	}
	
}