using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 成就领奖答复 message
 */
public class ResDailyMissionRewardMessage : Message 
{
	//成就Id
	int _missionId;	
	//0：成功，1：未找到该id的任务，2：任务不是完成状态
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//成就Id
		SerializeUtils.WriteInt(stream, _missionId);
		//0：成功，1：未找到该id的任务，2：任务不是完成状态
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//成就Id
		_missionId = SerializeUtils.ReadInt(stream);
		//0：成功，1：未找到该id的任务，2：任务不是完成状态
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 成就Id
	 */
	public int MissionId
	{
		set { _missionId = value; }
	    get { return _missionId; }
	}
	
	/**
	 * 0：成功，1：未找到该id的任务，2：任务不是完成状态
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 214102;
	}
}