using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 书院技能书属性
 */
public class CollegeAttributeInfo : IMessageSerialize 
{
	//技能书1威力
	int _skill1CollegePct;	
	//技能书2威力
	int _skill2CollegePct;	
	//技能书3威力
	int _skill3CollegePct;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//技能书1威力
		SerializeUtils.WriteInt(stream, _skill1CollegePct);
		//技能书2威力
		SerializeUtils.WriteInt(stream, _skill2CollegePct);
		//技能书3威力
		SerializeUtils.WriteInt(stream, _skill3CollegePct);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//技能书1威力
		_skill1CollegePct = SerializeUtils.ReadInt(stream);
		//技能书2威力
		_skill2CollegePct = SerializeUtils.ReadInt(stream);
		//技能书3威力
		_skill3CollegePct = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 技能书1威力
	 */
	public int Skill1CollegePct
	{
		set { _skill1CollegePct = value; }
	    get { return _skill1CollegePct; }
	}
	
	/**
	 * 技能书2威力
	 */
	public int Skill2CollegePct
	{
		set { _skill2CollegePct = value; }
	    get { return _skill2CollegePct; }
	}
	
	/**
	 * 技能书3威力
	 */
	public int Skill3CollegePct
	{
		set { _skill3CollegePct = value; }
	    get { return _skill3CollegePct; }
	}
	
}