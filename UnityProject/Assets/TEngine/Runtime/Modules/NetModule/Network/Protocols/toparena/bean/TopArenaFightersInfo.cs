using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 巅峰竞技场出战角色信息
 */
public class TopArenaFightersInfo : IMessageSerialize 
{
	//服务器名称
	string _serverName;	
	//玩家id
	long _playerId;	
	//名称
	string _playerName;	
	//等级
	int _playerLevel;	
	//段位
	int _grade;	
	//积分
	int _score;	
	//出战队伍信息
	List<TopArenaOpponentCharacterInfo> _opponentCharacterInfos = new List<TopArenaOpponentCharacterInfo>();
	//灵骸阶级
	int _skeletonStage;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//服务器名称
		SerializeUtils.WriteString(stream, _serverName);
		//玩家id
		SerializeUtils.WriteLong(stream, _playerId);
		//名称
		SerializeUtils.WriteString(stream, _playerName);
		//等级
		SerializeUtils.WriteInt(stream, _playerLevel);
		//段位
		SerializeUtils.WriteInt(stream, _grade);
		//积分
		SerializeUtils.WriteInt(stream, _score);
		//出战队伍信息
		SerializeUtils.WriteShort(stream, (short)_opponentCharacterInfos.Count);

		foreach (var element in _opponentCharacterInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//灵骸阶级
		SerializeUtils.WriteInt(stream, _skeletonStage);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//服务器名称
		_serverName = SerializeUtils.ReadString(stream);
		//玩家id
		_playerId = SerializeUtils.ReadLong(stream);
		//名称
		_playerName = SerializeUtils.ReadString(stream);
		//等级
		_playerLevel = SerializeUtils.ReadInt(stream);
		//段位
		_grade = SerializeUtils.ReadInt(stream);
		//积分
		_score = SerializeUtils.ReadInt(stream);
		//出战队伍信息
		int _opponentCharacterInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _opponentCharacterInfos_length; ++i) 
		{
			_opponentCharacterInfos.Add(SerializeUtils.ReadBean<TopArenaOpponentCharacterInfo>(stream));
		}
		//灵骸阶级
		_skeletonStage = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 服务器名称
	 */
	public string ServerName
	{
		set { _serverName = value; }
	    get { return _serverName; }
	}
	
	/**
	 * 玩家id
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	/**
	 * 名称
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * 等级
	 */
	public int PlayerLevel
	{
		set { _playerLevel = value; }
	    get { return _playerLevel; }
	}
	
	/**
	 * 段位
	 */
	public int Grade
	{
		set { _grade = value; }
	    get { return _grade; }
	}
	
	/**
	 * 积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
	/**
	 * get 出战队伍信息
	 * @return 
	 */
	public List<TopArenaOpponentCharacterInfo> GetOpponentCharacterInfos()
	{
		return _opponentCharacterInfos;
	}
	
	/**
	 * set 出战队伍信息
	 */
	public void SetOpponentCharacterInfos(List<TopArenaOpponentCharacterInfo> opponentCharacterInfos)
	{
		_opponentCharacterInfos = opponentCharacterInfos;
	}
	
	/**
	 * 灵骸阶级
	 */
	public int SkeletonStage
	{
		set { _skeletonStage = value; }
	    get { return _skeletonStage; }
	}
	
}