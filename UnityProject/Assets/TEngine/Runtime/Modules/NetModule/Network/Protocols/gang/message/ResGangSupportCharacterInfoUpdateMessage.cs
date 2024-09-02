using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队玩家助战角色信息变更 message
 */
public class ResGangSupportCharacterInfoUpdateMessage : Message 
{
	//番队玩家助战角色信息
	GangSupportCharacterInfo _supportCharacterInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队玩家助战角色信息
		SerializeUtils.WriteBean(stream, _supportCharacterInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队玩家助战角色信息
		_supportCharacterInfo = SerializeUtils.ReadBean<GangSupportCharacterInfo>(stream);
	}
	
	/**
	 * 番队玩家助战角色信息
	 */
	public GangSupportCharacterInfo SupportCharacterInfo
	{
		set { _supportCharacterInfo = value; }
	    get { return _supportCharacterInfo; }
	}
	
	
	public override int GetId() 
	{
		return 109127;
	}
}