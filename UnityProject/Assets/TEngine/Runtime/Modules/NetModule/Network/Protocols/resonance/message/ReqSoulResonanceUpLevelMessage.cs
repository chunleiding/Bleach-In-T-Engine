using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 魂共鸣技能升级请求 message
 */
public class ReqSoulResonanceUpLevelMessage : Message 
{
	//技能id
	int _skillId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//技能id
		SerializeUtils.WriteInt(stream, _skillId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//技能id
		_skillId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 技能id
	 */
	public int SkillId
	{
		set { _skillId = value; }
	    get { return _skillId; }
	}
	
	
	public override int GetId() 
	{
		return 111201;
	}
}