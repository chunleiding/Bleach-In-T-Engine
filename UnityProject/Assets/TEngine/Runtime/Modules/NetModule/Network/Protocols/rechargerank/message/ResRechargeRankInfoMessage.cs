using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 充值 消耗排行榜信息 message
 */
public class ResRechargeRankInfoMessage : Message 
{
	//活动开始时间
	string _startTime;	
	//活动结束时间
	string _endTime;	
	//今日剩余时间 单位：秒
	int _todayLeftTime;	
	//展示开始时间
	string _startShowTime;	
	//展示结束时间
	string _endShowTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//活动开始时间
		SerializeUtils.WriteString(stream, _startTime);
		//活动结束时间
		SerializeUtils.WriteString(stream, _endTime);
		//今日剩余时间 单位：秒
		SerializeUtils.WriteInt(stream, _todayLeftTime);
		//展示开始时间
		SerializeUtils.WriteString(stream, _startShowTime);
		//展示结束时间
		SerializeUtils.WriteString(stream, _endShowTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//活动开始时间
		_startTime = SerializeUtils.ReadString(stream);
		//活动结束时间
		_endTime = SerializeUtils.ReadString(stream);
		//今日剩余时间 单位：秒
		_todayLeftTime = SerializeUtils.ReadInt(stream);
		//展示开始时间
		_startShowTime = SerializeUtils.ReadString(stream);
		//展示结束时间
		_endShowTime = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 活动开始时间
	 */
	public string StartTime
	{
		set { _startTime = value; }
	    get { return _startTime; }
	}
	
	/**
	 * 活动结束时间
	 */
	public string EndTime
	{
		set { _endTime = value; }
	    get { return _endTime; }
	}
	
	/**
	 * 今日剩余时间 单位：秒
	 */
	public int TodayLeftTime
	{
		set { _todayLeftTime = value; }
	    get { return _todayLeftTime; }
	}
	
	/**
	 * 展示开始时间
	 */
	public string StartShowTime
	{
		set { _startShowTime = value; }
	    get { return _startShowTime; }
	}
	
	/**
	 * 展示结束时间
	 */
	public string EndShowTime
	{
		set { _endShowTime = value; }
	    get { return _endShowTime; }
	}
	
	
	public override int GetId() 
	{
		return 819101;
	}
}