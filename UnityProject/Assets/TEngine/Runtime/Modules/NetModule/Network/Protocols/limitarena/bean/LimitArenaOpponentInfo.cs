using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 无间之战对手信息
 */
public class LimitArenaOpponentInfo : IMessageSerialize 
{
	//服务器名称
	string _serverName;	
	//玩家id
	long _playerId;	
	//对手名称
	string _playerName;	
	//对手等级
	int _playerLevel;	
	//战斗力
	int _fighting;	
	//出战角色列表
	List<ArenaFightCharacterInfo> _fightCharacters = new List<ArenaFightCharacterInfo>();
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
		//对手名称
		SerializeUtils.WriteString(stream, _playerName);
		//对手等级
		SerializeUtils.WriteInt(stream, _playerLevel);
		//战斗力
		SerializeUtils.WriteInt(stream, _fighting);
		//出战角色列表
		SerializeUtils.WriteShort(stream, (short)_fightCharacters.Count);

		foreach (var element in _fightCharacters)  
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
		//对手名称
		_playerName = SerializeUtils.ReadString(stream);
		//对手等级
		_playerLevel = SerializeUtils.ReadInt(stream);
		//战斗力
		_fighting = SerializeUtils.ReadInt(stream);
		//出战角色列表
		int _fightCharacters_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _fightCharacters_length; ++i) 
		{
			_fightCharacters.Add(SerializeUtils.ReadBean<ArenaFightCharacterInfo>(stream));
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
	 * 对手名称
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * 对手等级
	 */
	public int PlayerLevel
	{
		set { _playerLevel = value; }
	    get { return _playerLevel; }
	}
	
	/**
	 * 战斗力
	 */
	public int Fighting
	{
		set { _fighting = value; }
	    get { return _fighting; }
	}
	
	/**
	 * get 出战角色列表
	 * @return 
	 */
	public List<ArenaFightCharacterInfo> GetFightCharacters()
	{
		return _fightCharacters;
	}
	
	/**
	 * set 出战角色列表
	 */
	public void SetFightCharacters(List<ArenaFightCharacterInfo> fightCharacters)
	{
		_fightCharacters = fightCharacters;
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