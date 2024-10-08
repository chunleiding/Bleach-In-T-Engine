using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 竞技场排行榜
 */
public class SoulResonance : IMessageSerialize 
{
	//技能id
	int _skillId;	
	//技能等级
	int _level;	
	//0没用 1在用
	byte _isEnable;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//技能id
		SerializeUtils.WriteInt(stream, _skillId);
		//技能等级
		SerializeUtils.WriteInt(stream, _level);
		//0没用 1在用
		SerializeUtils.WriteByte(stream, _isEnable);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//技能id
		_skillId = SerializeUtils.ReadInt(stream);
		//技能等级
		_level = SerializeUtils.ReadInt(stream);
		//0没用 1在用
		_isEnable = SerializeUtils.ReadByte(stream);
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
	public int Level
	{
		set { _level = value; }
	    get { return _level; }
	}
	
	/**
	 * 0没用 1在用
	 */
	public byte IsEnable
	{
		set { _isEnable = value; }
	    get { return _isEnable; }
	}
	
}