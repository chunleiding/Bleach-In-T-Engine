using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战排行榜
 */
public class GangBattleRankBean : IMessageSerialize 
{
	//番队id
	long _gangId;	
	//番队名
	string _gangName;	
	//番队队徽
	int _gangFlag;	
	//队长名
	string _leaderName;	
	//番队等级
	int _gangLevel;	
	//番队积分
	int _gangScore;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//番队id
		SerializeUtils.WriteLong(stream, _gangId);
		//番队名
		SerializeUtils.WriteString(stream, _gangName);
		//番队队徽
		SerializeUtils.WriteInt(stream, _gangFlag);
		//队长名
		SerializeUtils.WriteString(stream, _leaderName);
		//番队等级
		SerializeUtils.WriteInt(stream, _gangLevel);
		//番队积分
		SerializeUtils.WriteInt(stream, _gangScore);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//番队id
		_gangId = SerializeUtils.ReadLong(stream);
		//番队名
		_gangName = SerializeUtils.ReadString(stream);
		//番队队徽
		_gangFlag = SerializeUtils.ReadInt(stream);
		//队长名
		_leaderName = SerializeUtils.ReadString(stream);
		//番队等级
		_gangLevel = SerializeUtils.ReadInt(stream);
		//番队积分
		_gangScore = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 番队id
	 */
	public long GangId
	{
		set { _gangId = value; }
	    get { return _gangId; }
	}
	
	/**
	 * 番队名
	 */
	public string GangName
	{
		set { _gangName = value; }
	    get { return _gangName; }
	}
	
	/**
	 * 番队队徽
	 */
	public int GangFlag
	{
		set { _gangFlag = value; }
	    get { return _gangFlag; }
	}
	
	/**
	 * 队长名
	 */
	public string LeaderName
	{
		set { _leaderName = value; }
	    get { return _leaderName; }
	}
	
	/**
	 * 番队等级
	 */
	public int GangLevel
	{
		set { _gangLevel = value; }
	    get { return _gangLevel; }
	}
	
	/**
	 * 番队积分
	 */
	public int GangScore
	{
		set { _gangScore = value; }
	    get { return _gangScore; }
	}
	
}