using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 单条日常任务信息 message
 */
public class ResDailyMissionInfoMessage : Message 
{
	//单条日常任务信息
	DailyMissionInfo _missionInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//单条日常任务信息
		SerializeUtils.WriteBean(stream, _missionInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//单条日常任务信息
		_missionInfo = SerializeUtils.ReadBean<DailyMissionInfo>(stream);
	}
	
	/**
	 * 单条日常任务信息
	 */
	public DailyMissionInfo MissionInfo
	{
		set { _missionInfo = value; }
	    get { return _missionInfo; }
	}
	
	
	public override int GetId() 
	{
		return 214101;
	}
}