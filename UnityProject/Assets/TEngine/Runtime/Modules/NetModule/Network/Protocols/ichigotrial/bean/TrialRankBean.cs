using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家试炼排行信息
 */
public class TrialRankBean : IMessageSerialize 
{
	//玩家名称
	string _playerName;	
	//积分
	int _score;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//玩家名称
		SerializeUtils.WriteString(stream, _playerName);
		//积分
		SerializeUtils.WriteInt(stream, _score);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//玩家名称
		_playerName = SerializeUtils.ReadString(stream);
		//积分
		_score = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 玩家名称
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * 积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
}