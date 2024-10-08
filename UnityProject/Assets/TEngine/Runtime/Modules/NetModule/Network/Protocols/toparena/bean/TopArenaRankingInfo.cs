using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 巅峰竞技场排行榜信息
 */
public class TopArenaRankingInfo : IMessageSerialize 
{
	//服务器id
	int _serverId;	
	//服务器名称
	string _serverName;	
	//玩家id
	long _playerId;	
	//玩家名称
	string _playerName;	
	//段位
	int _grade;	
	//积分
	int _score;	
	//比赛次数
	int _fightTime;	
	//胜利次数
	int _winTime;	
	//出战角色列表
	List<TopArenaRankingFightTeamInfo> _fightTeamInfos = new List<TopArenaRankingFightTeamInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//服务器id
		SerializeUtils.WriteInt(stream, _serverId);
		//服务器名称
		SerializeUtils.WriteString(stream, _serverName);
		//玩家id
		SerializeUtils.WriteLong(stream, _playerId);
		//玩家名称
		SerializeUtils.WriteString(stream, _playerName);
		//段位
		SerializeUtils.WriteInt(stream, _grade);
		//积分
		SerializeUtils.WriteInt(stream, _score);
		//比赛次数
		SerializeUtils.WriteInt(stream, _fightTime);
		//胜利次数
		SerializeUtils.WriteInt(stream, _winTime);
		//出战角色列表
		SerializeUtils.WriteShort(stream, (short)_fightTeamInfos.Count);

		foreach (var element in _fightTeamInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//服务器id
		_serverId = SerializeUtils.ReadInt(stream);
		//服务器名称
		_serverName = SerializeUtils.ReadString(stream);
		//玩家id
		_playerId = SerializeUtils.ReadLong(stream);
		//玩家名称
		_playerName = SerializeUtils.ReadString(stream);
		//段位
		_grade = SerializeUtils.ReadInt(stream);
		//积分
		_score = SerializeUtils.ReadInt(stream);
		//比赛次数
		_fightTime = SerializeUtils.ReadInt(stream);
		//胜利次数
		_winTime = SerializeUtils.ReadInt(stream);
		//出战角色列表
		int _fightTeamInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _fightTeamInfos_length; ++i) 
		{
			_fightTeamInfos.Add(SerializeUtils.ReadBean<TopArenaRankingFightTeamInfo>(stream));
		}
	}
	
	/**
	 * 服务器id
	 */
	public int ServerId
	{
		set { _serverId = value; }
	    get { return _serverId; }
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
	 * 玩家名称
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
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
	 * 比赛次数
	 */
	public int FightTime
	{
		set { _fightTime = value; }
	    get { return _fightTime; }
	}
	
	/**
	 * 胜利次数
	 */
	public int WinTime
	{
		set { _winTime = value; }
	    get { return _winTime; }
	}
	
	/**
	 * get 出战角色列表
	 * @return 
	 */
	public List<TopArenaRankingFightTeamInfo> GetFightTeamInfos()
	{
		return _fightTeamInfos;
	}
	
	/**
	 * set 出战角色列表
	 */
	public void SetFightTeamInfos(List<TopArenaRankingFightTeamInfo> fightTeamInfos)
	{
		_fightTeamInfos = fightTeamInfos;
	}
	
}