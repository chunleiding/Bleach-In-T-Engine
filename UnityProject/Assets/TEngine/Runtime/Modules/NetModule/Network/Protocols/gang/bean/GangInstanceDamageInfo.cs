using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 副本伤害信息
 */
public class GangInstanceDamageInfo : IMessageSerialize 
{
	//玩家id
	long _playerId;	
	//造成的伤害血量总值
	long _hp;	
	//造成单次最大伤害的角色id
	int _characterId;	
	//造成单次最大伤害的角色阶级
	int _characterStageLevel;	
	//造成单次最大伤害的角色星级
	int _characterGrowthLevel;	
	//造成单次最大伤害的血量
	long _characterHp;	
	//副本挑战次数
	int _challengeNum;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//玩家id
		SerializeUtils.WriteLong(stream, _playerId);
		//造成的伤害血量总值
		SerializeUtils.WriteLong(stream, _hp);
		//造成单次最大伤害的角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//造成单次最大伤害的角色阶级
		SerializeUtils.WriteInt(stream, _characterStageLevel);
		//造成单次最大伤害的角色星级
		SerializeUtils.WriteInt(stream, _characterGrowthLevel);
		//造成单次最大伤害的血量
		SerializeUtils.WriteLong(stream, _characterHp);
		//副本挑战次数
		SerializeUtils.WriteInt(stream, _challengeNum);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//玩家id
		_playerId = SerializeUtils.ReadLong(stream);
		//造成的伤害血量总值
		_hp = SerializeUtils.ReadLong(stream);
		//造成单次最大伤害的角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//造成单次最大伤害的角色阶级
		_characterStageLevel = SerializeUtils.ReadInt(stream);
		//造成单次最大伤害的角色星级
		_characterGrowthLevel = SerializeUtils.ReadInt(stream);
		//造成单次最大伤害的血量
		_characterHp = SerializeUtils.ReadLong(stream);
		//副本挑战次数
		_challengeNum = SerializeUtils.ReadInt(stream);
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
	 * 造成的伤害血量总值
	 */
	public long Hp
	{
		set { _hp = value; }
	    get { return _hp; }
	}
	
	/**
	 * 造成单次最大伤害的角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 造成单次最大伤害的角色阶级
	 */
	public int CharacterStageLevel
	{
		set { _characterStageLevel = value; }
	    get { return _characterStageLevel; }
	}
	
	/**
	 * 造成单次最大伤害的角色星级
	 */
	public int CharacterGrowthLevel
	{
		set { _characterGrowthLevel = value; }
	    get { return _characterGrowthLevel; }
	}
	
	/**
	 * 造成单次最大伤害的血量
	 */
	public long CharacterHp
	{
		set { _characterHp = value; }
	    get { return _characterHp; }
	}
	
	/**
	 * 副本挑战次数
	 */
	public int ChallengeNum
	{
		set { _challengeNum = value; }
	    get { return _challengeNum; }
	}
	
}