using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求使用技能 message
 */
public class ReqUesSkillMessage : Message 
{
	//0启用 1卸下
	int _useState;	
	//技能id
	int _skillId;	
	//技能等级
	int _skillLevel;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0启用 1卸下
		SerializeUtils.WriteInt(stream, _useState);
		//技能id
		SerializeUtils.WriteInt(stream, _skillId);
		//技能等级
		SerializeUtils.WriteInt(stream, _skillLevel);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0启用 1卸下
		_useState = SerializeUtils.ReadInt(stream);
		//技能id
		_skillId = SerializeUtils.ReadInt(stream);
		//技能等级
		_skillLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0启用 1卸下
	 */
	public int UseState
	{
		set { _useState = value; }
	    get { return _useState; }
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
	 * 技能等级
	 */
	public int SkillLevel
	{
		set { _skillLevel = value; }
	    get { return _skillLevel; }
	}
	
	
	public override int GetId() 
	{
		return 822105;
	}
}