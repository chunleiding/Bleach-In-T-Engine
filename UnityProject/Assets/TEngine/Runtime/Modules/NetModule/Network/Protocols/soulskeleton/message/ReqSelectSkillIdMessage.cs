using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 选择启用技能id message
 */
public class ReqSelectSkillIdMessage : Message 
{
	//灵骸技能id
	int _skillId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//灵骸技能id
		SerializeUtils.WriteInt(stream, _skillId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//灵骸技能id
		_skillId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 灵骸技能id
	 */
	public int SkillId
	{
		set { _skillId = value; }
	    get { return _skillId; }
	}
	
	
	public override int GetId() 
	{
		return 809102;
	}
}