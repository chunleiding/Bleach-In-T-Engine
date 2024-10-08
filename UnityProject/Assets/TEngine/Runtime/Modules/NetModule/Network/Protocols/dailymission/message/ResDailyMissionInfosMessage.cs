using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 全部日常任务信息 message
 */
public class ResDailyMissionInfosMessage : Message 
{
	//日常任务信息
	List<DailyMissionInfo> _missionInfos = new List<DailyMissionInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//日常任务信息
		SerializeUtils.WriteShort(stream, (short)_missionInfos.Count);

		foreach (var element in _missionInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//日常任务信息
		int _missionInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _missionInfos_length; ++i) 
		{
			_missionInfos.Add(SerializeUtils.ReadBean<DailyMissionInfo>(stream));
		}
	}
	
	/**
	 * get 日常任务信息
	 * @return 
	 */
	public List<DailyMissionInfo> GetMissionInfos()
	{
		return _missionInfos;
	}
	
	/**
	 * set 日常任务信息
	 */
	public void SetMissionInfos(List<DailyMissionInfo> missionInfos)
	{
		_missionInfos = missionInfos;
	}
	
	
	public override int GetId() 
	{
		return 214300;
	}
}