using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵魂能力信息
 */
public class SoulAbilityInfo : IMessageSerialize 
{
	//灵魂能力id
	int _id;	
	//灵魂能力等级
	int _soulAbilityLevel;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//灵魂能力id
		SerializeUtils.WriteInt(stream, _id);
		//灵魂能力等级
		SerializeUtils.WriteInt(stream, _soulAbilityLevel);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//灵魂能力id
		_id = SerializeUtils.ReadInt(stream);
		//灵魂能力等级
		_soulAbilityLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 灵魂能力id
	 */
	public int Id
	{
		set { _id = value; }
	    get { return _id; }
	}
	
	/**
	 * 灵魂能力等级
	 */
	public int SoulAbilityLevel
	{
		set { _soulAbilityLevel = value; }
	    get { return _soulAbilityLevel; }
	}
	
}