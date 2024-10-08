using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 对手番队玩家信息 message
 */
public class ResGangBattleOppoFightersInfoMessage : Message 
{
	//服务器id
	int _serverId;	
	//服务器名
	string _serverName;	
	//番队名
	string _gangName;	
	//番队等级
	int _gangLevel;	
	//番队队徽
	int _gangFlag;	
	//队长名
	string _leaderName;	
	//积分
	int _score;	
	//对手番队玩家信息
	List<GangBattleFighterInfo> _oppoFighterInfos = new List<GangBattleFighterInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//服务器id
		SerializeUtils.WriteInt(stream, _serverId);
		//服务器名
		SerializeUtils.WriteString(stream, _serverName);
		//番队名
		SerializeUtils.WriteString(stream, _gangName);
		//番队等级
		SerializeUtils.WriteInt(stream, _gangLevel);
		//番队队徽
		SerializeUtils.WriteInt(stream, _gangFlag);
		//队长名
		SerializeUtils.WriteString(stream, _leaderName);
		//积分
		SerializeUtils.WriteInt(stream, _score);
		//对手番队玩家信息
		SerializeUtils.WriteShort(stream, (short)_oppoFighterInfos.Count);

		foreach (var element in _oppoFighterInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//服务器id
		_serverId = SerializeUtils.ReadInt(stream);
		//服务器名
		_serverName = SerializeUtils.ReadString(stream);
		//番队名
		_gangName = SerializeUtils.ReadString(stream);
		//番队等级
		_gangLevel = SerializeUtils.ReadInt(stream);
		//番队队徽
		_gangFlag = SerializeUtils.ReadInt(stream);
		//队长名
		_leaderName = SerializeUtils.ReadString(stream);
		//积分
		_score = SerializeUtils.ReadInt(stream);
		//对手番队玩家信息
		int _oppoFighterInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _oppoFighterInfos_length; ++i) 
		{
			_oppoFighterInfos.Add(SerializeUtils.ReadBean<GangBattleFighterInfo>(stream));
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
	 * 服务器名
	 */
	public string ServerName
	{
		set { _serverName = value; }
	    get { return _serverName; }
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
	 * 番队等级
	 */
	public int GangLevel
	{
		set { _gangLevel = value; }
	    get { return _gangLevel; }
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
	 * 积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
	/**
	 * get 对手番队玩家信息
	 * @return 
	 */
	public List<GangBattleFighterInfo> GetOppoFighterInfos()
	{
		return _oppoFighterInfos;
	}
	
	/**
	 * set 对手番队玩家信息
	 */
	public void SetOppoFighterInfos(List<GangBattleFighterInfo> oppoFighterInfos)
	{
		_oppoFighterInfos = oppoFighterInfos;
	}
	
	
	public override int GetId() 
	{
		return 112104;
	}
}