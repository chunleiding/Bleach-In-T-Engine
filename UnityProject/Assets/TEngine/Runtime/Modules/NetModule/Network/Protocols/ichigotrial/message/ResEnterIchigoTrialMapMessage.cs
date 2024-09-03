using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 进入一护试炼地图回复消息 message
 */
public class ResEnterIchigoTrialMapMessage : Message 
{
	//场景id
	int _levelId;	
	//战斗时长
	int _time;	
	//结果 0：成功；大于0：失败
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//场景id
		SerializeUtils.WriteInt(stream, _levelId);
		//战斗时长
		SerializeUtils.WriteInt(stream, _time);
		//结果 0：成功；大于0：失败
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//场景id
		_levelId = SerializeUtils.ReadInt(stream);
		//战斗时长
		_time = SerializeUtils.ReadInt(stream);
		//结果 0：成功；大于0：失败
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 场景id
	 */
	public int LevelId
	{
		set { _levelId = value; }
	    get { return _levelId; }
	}
	
	/**
	 * 战斗时长
	 */
	public int Time
	{
		set { _time = value; }
	    get { return _time; }
	}
	
	/**
	 * 结果 0：成功；大于0：失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 825110;
	}
}