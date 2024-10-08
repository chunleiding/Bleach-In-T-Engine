using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 装备信息
 */
public class EquipInfo : IMessageSerialize 
{
	//装备id
	int _equipmentId;	
	//装备等级
	int _level;	
	//装备阶级
	int _stage;	
	//角色成长等级
	int _growthLevel;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//装备id
		SerializeUtils.WriteInt(stream, _equipmentId);
		//装备等级
		SerializeUtils.WriteInt(stream, _level);
		//装备阶级
		SerializeUtils.WriteInt(stream, _stage);
		//角色成长等级
		SerializeUtils.WriteInt(stream, _growthLevel);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//装备id
		_equipmentId = SerializeUtils.ReadInt(stream);
		//装备等级
		_level = SerializeUtils.ReadInt(stream);
		//装备阶级
		_stage = SerializeUtils.ReadInt(stream);
		//角色成长等级
		_growthLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 装备id
	 */
	public int EquipmentId
	{
		set { _equipmentId = value; }
	    get { return _equipmentId; }
	}
	
	/**
	 * 装备等级
	 */
	public int Level
	{
		set { _level = value; }
	    get { return _level; }
	}
	
	/**
	 * 装备阶级
	 */
	public int Stage
	{
		set { _stage = value; }
	    get { return _stage; }
	}
	
	/**
	 * 角色成长等级
	 */
	public int GrowthLevel
	{
		set { _growthLevel = value; }
	    get { return _growthLevel; }
	}
	
}