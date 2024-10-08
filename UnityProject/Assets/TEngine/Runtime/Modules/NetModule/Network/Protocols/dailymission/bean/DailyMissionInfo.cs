using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 日常任务信息
 */
public class DailyMissionInfo : IMessageSerialize 
{
	//任务Id
	int _missionId;	
	//进度值
	int _value;	
	//状态，0-未完成，1-已完成，2-已领奖
	int _status;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//任务Id
		SerializeUtils.WriteInt(stream, _missionId);
		//进度值
		SerializeUtils.WriteInt(stream, _value);
		//状态，0-未完成，1-已完成，2-已领奖
		SerializeUtils.WriteInt(stream, _status);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//任务Id
		_missionId = SerializeUtils.ReadInt(stream);
		//进度值
		_value = SerializeUtils.ReadInt(stream);
		//状态，0-未完成，1-已完成，2-已领奖
		_status = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 任务Id
	 */
	public int MissionId
	{
		set { _missionId = value; }
	    get { return _missionId; }
	}
	
	/**
	 * 进度值
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
	/**
	 * 状态，0-未完成，1-已完成，2-已领奖
	 */
	public int Status
	{
		set { _status = value; }
	    get { return _status; }
	}
	
}