using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 成就信息 message
 */
public class ResAchievementInfoMessage : Message 
{
	//成就信息
	AchievementInfo _achieveInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//成就信息
		SerializeUtils.WriteBean(stream, _achieveInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//成就信息
		_achieveInfo = SerializeUtils.ReadBean<AchievementInfo>(stream);
	}
	
	/**
	 * 成就信息
	 */
	public AchievementInfo AchieveInfo
	{
		set { _achieveInfo = value; }
	    get { return _achieveInfo; }
	}
	
	
	public override int GetId() 
	{
		return 210101;
	}
}