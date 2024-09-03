using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 副本群通关排行榜信息
 */
public class ExploreRankBean : IMessageSerialize 
{
	//通关时间
	int _finishTime;	
	//玩家名字
	string _playerName;	
	//玩家id
	long _playerId;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//通关时间
		SerializeUtils.WriteInt(stream, _finishTime);
		//玩家名字
		SerializeUtils.WriteString(stream, _playerName);
		//玩家id
		SerializeUtils.WriteLong(stream, _playerId);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//通关时间
		_finishTime = SerializeUtils.ReadInt(stream);
		//玩家名字
		_playerName = SerializeUtils.ReadString(stream);
		//玩家id
		_playerId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 通关时间
	 */
	public int FinishTime
	{
		set { _finishTime = value; }
	    get { return _finishTime; }
	}
	
	/**
	 * 玩家名字
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * 玩家id
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
}