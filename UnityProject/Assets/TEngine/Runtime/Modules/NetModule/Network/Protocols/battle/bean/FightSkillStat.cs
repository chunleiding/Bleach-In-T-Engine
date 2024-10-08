using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 战斗技能统计
 */
public class FightSkillStat : IMessageSerialize 
{
	//技能id
	int _skillId;	
	//技能使用次数
	int _skillCount;	
	//最小释放间隔
	int _minInterval;	
	//单次最高伤害
	int _maxDamage;	
	//单次最高伤害敌方id
	int _maxDamageEnemyId;	
	//单次最高伤害时，自己身上的buff列表
	List<int> _selfBuffIds = new List<int>();
	//单次最高伤害时，敌方身上的buff列表
	List<int> _enemyBuffIds = new List<int>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//技能id
		SerializeUtils.WriteInt(stream, _skillId);
		//技能使用次数
		SerializeUtils.WriteInt(stream, _skillCount);
		//最小释放间隔
		SerializeUtils.WriteInt(stream, _minInterval);
		//单次最高伤害
		SerializeUtils.WriteInt(stream, _maxDamage);
		//单次最高伤害敌方id
		SerializeUtils.WriteInt(stream, _maxDamageEnemyId);
		//单次最高伤害时，自己身上的buff列表
		SerializeUtils.WriteShort(stream, (short)_selfBuffIds.Count);

		foreach (var element in _selfBuffIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//单次最高伤害时，敌方身上的buff列表
		SerializeUtils.WriteShort(stream, (short)_enemyBuffIds.Count);

		foreach (var element in _enemyBuffIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//技能id
		_skillId = SerializeUtils.ReadInt(stream);
		//技能使用次数
		_skillCount = SerializeUtils.ReadInt(stream);
		//最小释放间隔
		_minInterval = SerializeUtils.ReadInt(stream);
		//单次最高伤害
		_maxDamage = SerializeUtils.ReadInt(stream);
		//单次最高伤害敌方id
		_maxDamageEnemyId = SerializeUtils.ReadInt(stream);
		//单次最高伤害时，自己身上的buff列表
		int _selfBuffIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _selfBuffIds_length; ++i) 
		{
			_selfBuffIds.Add(SerializeUtils.ReadInt(stream));
		}
		//单次最高伤害时，敌方身上的buff列表
		int _enemyBuffIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _enemyBuffIds_length; ++i) 
		{
			_enemyBuffIds.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 技能id
	 */
	public int SkillId
	{
		set { _skillId = value; }
	    get { return _skillId; }
	}
	
	/**
	 * 技能使用次数
	 */
	public int SkillCount
	{
		set { _skillCount = value; }
	    get { return _skillCount; }
	}
	
	/**
	 * 最小释放间隔
	 */
	public int MinInterval
	{
		set { _minInterval = value; }
	    get { return _minInterval; }
	}
	
	/**
	 * 单次最高伤害
	 */
	public int MaxDamage
	{
		set { _maxDamage = value; }
	    get { return _maxDamage; }
	}
	
	/**
	 * 单次最高伤害敌方id
	 */
	public int MaxDamageEnemyId
	{
		set { _maxDamageEnemyId = value; }
	    get { return _maxDamageEnemyId; }
	}
	
	/**
	 * get 单次最高伤害时，自己身上的buff列表
	 * @return 
	 */
	public List<int> GetSelfBuffIds()
	{
		return _selfBuffIds;
	}
	
	/**
	 * set 单次最高伤害时，自己身上的buff列表
	 */
	public void SetSelfBuffIds(List<int> selfBuffIds)
	{
		_selfBuffIds = selfBuffIds;
	}
	
	/**
	 * get 单次最高伤害时，敌方身上的buff列表
	 * @return 
	 */
	public List<int> GetEnemyBuffIds()
	{
		return _enemyBuffIds;
	}
	
	/**
	 * set 单次最高伤害时，敌方身上的buff列表
	 */
	public void SetEnemyBuffIds(List<int> enemyBuffIds)
	{
		_enemyBuffIds = enemyBuffIds;
	}
	
}