using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 通关世界纪录
 */
public class LevelRecord : IMessageSerialize 
{
	//关卡id
	int _levelId;	
	//难度(0,1,2)
	int _levelDifficulty;	
	//玩家名字
	string _playerName;	
	//时间记录
	int _recordTime;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//关卡id
		SerializeUtils.WriteInt(stream, _levelId);
		//难度(0,1,2)
		SerializeUtils.WriteInt(stream, _levelDifficulty);
		//玩家名字
		SerializeUtils.WriteString(stream, _playerName);
		//时间记录
		SerializeUtils.WriteInt(stream, _recordTime);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//关卡id
		_levelId = SerializeUtils.ReadInt(stream);
		//难度(0,1,2)
		_levelDifficulty = SerializeUtils.ReadInt(stream);
		//玩家名字
		_playerName = SerializeUtils.ReadString(stream);
		//时间记录
		_recordTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 关卡id
	 */
	public int LevelId
	{
		set { _levelId = value; }
	    get { return _levelId; }
	}
	
	/**
	 * 难度(0,1,2)
	 */
	public int LevelDifficulty
	{
		set { _levelDifficulty = value; }
	    get { return _levelDifficulty; }
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
	 * 时间记录
	 */
	public int RecordTime
	{
		set { _recordTime = value; }
	    get { return _recordTime; }
	}
	
}