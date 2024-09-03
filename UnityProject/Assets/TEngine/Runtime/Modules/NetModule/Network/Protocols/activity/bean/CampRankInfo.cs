using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动排行榜信息
 */
public class CampRankInfo : IMessageSerialize 
{
	//排名
	int _rank;	
	//玩家名
	string _playerName;	
	//对应值
	int _value;	
	//玩家ID
	long _playerId;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//排名
		SerializeUtils.WriteInt(stream, _rank);
		//玩家名
		SerializeUtils.WriteString(stream, _playerName);
		//对应值
		SerializeUtils.WriteInt(stream, _value);
		//玩家ID
		SerializeUtils.WriteLong(stream, _playerId);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//排名
		_rank = SerializeUtils.ReadInt(stream);
		//玩家名
		_playerName = SerializeUtils.ReadString(stream);
		//对应值
		_value = SerializeUtils.ReadInt(stream);
		//玩家ID
		_playerId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 排名
	 */
	public int Rank
	{
		set { _rank = value; }
	    get { return _rank; }
	}
	
	/**
	 * 玩家名
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * 对应值
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
	/**
	 * 玩家ID
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
}