using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 技能格包涵数据
 */
public class SkiiBoxInfo : IMessageSerialize 
{
	//格子id
	int _boxId;	
	//是否激活 0没激活 1激活
	int _isActive;	
	//激活格子是够装备技能
	int _isEquipment;	
	//当前装备的技能id
	int _skillId;	
	//多少级解锁
	int _needLevel;	
	//技能等级
	int _skillLevel;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//格子id
		SerializeUtils.WriteInt(stream, _boxId);
		//是否激活 0没激活 1激活
		SerializeUtils.WriteInt(stream, _isActive);
		//激活格子是够装备技能
		SerializeUtils.WriteInt(stream, _isEquipment);
		//当前装备的技能id
		SerializeUtils.WriteInt(stream, _skillId);
		//多少级解锁
		SerializeUtils.WriteInt(stream, _needLevel);
		//技能等级
		SerializeUtils.WriteInt(stream, _skillLevel);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//格子id
		_boxId = SerializeUtils.ReadInt(stream);
		//是否激活 0没激活 1激活
		_isActive = SerializeUtils.ReadInt(stream);
		//激活格子是够装备技能
		_isEquipment = SerializeUtils.ReadInt(stream);
		//当前装备的技能id
		_skillId = SerializeUtils.ReadInt(stream);
		//多少级解锁
		_needLevel = SerializeUtils.ReadInt(stream);
		//技能等级
		_skillLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 格子id
	 */
	public int BoxId
	{
		set { _boxId = value; }
	    get { return _boxId; }
	}
	
	/**
	 * 是否激活 0没激活 1激活
	 */
	public int IsActive
	{
		set { _isActive = value; }
	    get { return _isActive; }
	}
	
	/**
	 * 激活格子是够装备技能
	 */
	public int IsEquipment
	{
		set { _isEquipment = value; }
	    get { return _isEquipment; }
	}
	
	/**
	 * 当前装备的技能id
	 */
	public int SkillId
	{
		set { _skillId = value; }
	    get { return _skillId; }
	}
	
	/**
	 * 多少级解锁
	 */
	public int NeedLevel
	{
		set { _needLevel = value; }
	    get { return _needLevel; }
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