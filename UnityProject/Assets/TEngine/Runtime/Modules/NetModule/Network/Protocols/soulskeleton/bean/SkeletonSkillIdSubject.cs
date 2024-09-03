using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵骸技能和启用状态
 */
public class SkeletonSkillIdSubject : IMessageSerialize 
{
	//技能id
	int _skillId;	
	//0:未启用；1：启用
	int _skillState;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//技能id
		SerializeUtils.WriteInt(stream, _skillId);
		//0:未启用；1：启用
		SerializeUtils.WriteInt(stream, _skillState);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//技能id
		_skillId = SerializeUtils.ReadInt(stream);
		//0:未启用；1：启用
		_skillState = SerializeUtils.ReadInt(stream);
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
	 * 0:未启用；1：启用
	 */
	public int SkillState
	{
		set { _skillState = value; }
	    get { return _skillState; }
	}
	
}