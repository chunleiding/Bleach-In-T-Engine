using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 魂共鸣技能升级回复 message
 */
public class ResSoulResonanceUpLevelMessage : Message 
{
	//0：成功，1：失败
	byte _success;	
	//升级后的魂共鸣信息
	SoulResonance _soulResonance;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功，1：失败
		SerializeUtils.WriteByte(stream, _success);
		//升级后的魂共鸣信息
		SerializeUtils.WriteBean(stream, _soulResonance);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功，1：失败
		_success = SerializeUtils.ReadByte(stream);
		//升级后的魂共鸣信息
		_soulResonance = SerializeUtils.ReadBean<SoulResonance>(stream);
	}
	
	/**
	 * 0：成功，1：失败
	 */
	public byte Success
	{
		set { _success = value; }
	    get { return _success; }
	}
	
	/**
	 * 升级后的魂共鸣信息
	 */
	public SoulResonance SoulResonance
	{
		set { _soulResonance = value; }
	    get { return _soulResonance; }
	}
	
	
	public override int GetId() 
	{
		return 111102;
	}
}