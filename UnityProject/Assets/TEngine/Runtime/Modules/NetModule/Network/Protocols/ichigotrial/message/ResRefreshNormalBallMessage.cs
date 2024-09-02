using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 刷新普通球回复 message
 */
public class ResRefreshNormalBallMessage : Message 
{
	//是否刷新加时球：0不刷，1刷
	int _isRefreshTimeBall;	
	//0：左边刷加时球，1：右边刷加时球
	int _leftOrRight;	
	//全路段球列表
	List<RoadBall> _roadBallList = new List<RoadBall>();
	//时间球的标识符
	string _timeBallUid;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//是否刷新加时球：0不刷，1刷
		SerializeUtils.WriteInt(stream, _isRefreshTimeBall);
		//0：左边刷加时球，1：右边刷加时球
		SerializeUtils.WriteInt(stream, _leftOrRight);
		//全路段球列表
		SerializeUtils.WriteShort(stream, (short)_roadBallList.Count);

		foreach (var element in _roadBallList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//时间球的标识符
		SerializeUtils.WriteString(stream, _timeBallUid);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//是否刷新加时球：0不刷，1刷
		_isRefreshTimeBall = SerializeUtils.ReadInt(stream);
		//0：左边刷加时球，1：右边刷加时球
		_leftOrRight = SerializeUtils.ReadInt(stream);
		//全路段球列表
		int _roadBallList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _roadBallList_length; ++i) 
		{
			_roadBallList.Add(SerializeUtils.ReadBean<RoadBall>(stream));
		}
		//时间球的标识符
		_timeBallUid = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 是否刷新加时球：0不刷，1刷
	 */
	public int IsRefreshTimeBall
	{
		set { _isRefreshTimeBall = value; }
	    get { return _isRefreshTimeBall; }
	}
	
	/**
	 * 0：左边刷加时球，1：右边刷加时球
	 */
	public int LeftOrRight
	{
		set { _leftOrRight = value; }
	    get { return _leftOrRight; }
	}
	
	/**
	 * get 全路段球列表
	 * @return 
	 */
	public List<RoadBall> GetRoadBallList()
	{
		return _roadBallList;
	}
	
	/**
	 * set 全路段球列表
	 */
	public void SetRoadBallList(List<RoadBall> roadBallList)
	{
		_roadBallList = roadBallList;
	}
	
	/**
	 * 时间球的标识符
	 */
	public string TimeBallUid
	{
		set { _timeBallUid = value; }
	    get { return _timeBallUid; }
	}
	
	
	public override int GetId() 
	{
		return 825112;
	}
}