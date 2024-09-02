using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 世界boss排名榜单
 */
public class WorldBossRank : IMessageSerialize 
{
	//玩家id
	long _playerId;	
	//玩家姓名
	string _playerName;	
	//名次
	int _rank;	
	//buff层数
	int _buffNum;	
	//排名奖励积分
	int _score;	
	//对Boss伤害
	int _damage;	
	//玩家等级
	int _level;	
	//角色id
	int _characterId;	
	//角色阶级
	int _stageLevel;	
	//成长率等级
	int _growthLv;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//玩家id
		SerializeUtils.WriteLong(stream, _playerId);
		//玩家姓名
		SerializeUtils.WriteString(stream, _playerName);
		//名次
		SerializeUtils.WriteInt(stream, _rank);
		//buff层数
		SerializeUtils.WriteInt(stream, _buffNum);
		//排名奖励积分
		SerializeUtils.WriteInt(stream, _score);
		//对Boss伤害
		SerializeUtils.WriteInt(stream, _damage);
		//玩家等级
		SerializeUtils.WriteInt(stream, _level);
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//角色阶级
		SerializeUtils.WriteInt(stream, _stageLevel);
		//成长率等级
		SerializeUtils.WriteInt(stream, _growthLv);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//玩家id
		_playerId = SerializeUtils.ReadLong(stream);
		//玩家姓名
		_playerName = SerializeUtils.ReadString(stream);
		//名次
		_rank = SerializeUtils.ReadInt(stream);
		//buff层数
		_buffNum = SerializeUtils.ReadInt(stream);
		//排名奖励积分
		_score = SerializeUtils.ReadInt(stream);
		//对Boss伤害
		_damage = SerializeUtils.ReadInt(stream);
		//玩家等级
		_level = SerializeUtils.ReadInt(stream);
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//角色阶级
		_stageLevel = SerializeUtils.ReadInt(stream);
		//成长率等级
		_growthLv = SerializeUtils.ReadInt(stream);
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
	 * 玩家姓名
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * 名次
	 */
	public int Rank
	{
		set { _rank = value; }
	    get { return _rank; }
	}
	
	/**
	 * buff层数
	 */
	public int BuffNum
	{
		set { _buffNum = value; }
	    get { return _buffNum; }
	}
	
	/**
	 * 排名奖励积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
	/**
	 * 对Boss伤害
	 */
	public int Damage
	{
		set { _damage = value; }
	    get { return _damage; }
	}
	
	/**
	 * 玩家等级
	 */
	public int Level
	{
		set { _level = value; }
	    get { return _level; }
	}
	
	/**
	 * 角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 角色阶级
	 */
	public int StageLevel
	{
		set { _stageLevel = value; }
	    get { return _stageLevel; }
	}
	
	/**
	 * 成长率等级
	 */
	public int GrowthLv
	{
		set { _growthLv = value; }
	    get { return _growthLv; }
	}
	
}