using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色剩余血量
 */
public class CharcaterLeftHpBean : IMessageSerialize 
{
	//角色剩余血量
	int _leftHp;	
	//角色id
	int _characterId;	
	//最大血量
	int _maxHp;	
	//战斗力
	int _fightPower;	
	//阶数
	int _stage;	
	//鬼道
	List<FightSkillInfo> _passiveSkills = new List<FightSkillInfo>();
	//成长阶级
	int _growthLevel;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色剩余血量
		SerializeUtils.WriteInt(stream, _leftHp);
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//最大血量
		SerializeUtils.WriteInt(stream, _maxHp);
		//战斗力
		SerializeUtils.WriteInt(stream, _fightPower);
		//阶数
		SerializeUtils.WriteInt(stream, _stage);
		//鬼道
		SerializeUtils.WriteShort(stream, (short)_passiveSkills.Count);

		foreach (var element in _passiveSkills)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//成长阶级
		SerializeUtils.WriteInt(stream, _growthLevel);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色剩余血量
		_leftHp = SerializeUtils.ReadInt(stream);
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//最大血量
		_maxHp = SerializeUtils.ReadInt(stream);
		//战斗力
		_fightPower = SerializeUtils.ReadInt(stream);
		//阶数
		_stage = SerializeUtils.ReadInt(stream);
		//鬼道
		int _passiveSkills_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _passiveSkills_length; ++i) 
		{
			_passiveSkills.Add(SerializeUtils.ReadBean<FightSkillInfo>(stream));
		}
		//成长阶级
		_growthLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色剩余血量
	 */
	public int LeftHp
	{
		set { _leftHp = value; }
	    get { return _leftHp; }
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
	 * 最大血量
	 */
	public int MaxHp
	{
		set { _maxHp = value; }
	    get { return _maxHp; }
	}
	
	/**
	 * 战斗力
	 */
	public int FightPower
	{
		set { _fightPower = value; }
	    get { return _fightPower; }
	}
	
	/**
	 * 阶数
	 */
	public int Stage
	{
		set { _stage = value; }
	    get { return _stage; }
	}
	
	/**
	 * get 鬼道
	 * @return 
	 */
	public List<FightSkillInfo> GetPassiveSkills()
	{
		return _passiveSkills;
	}
	
	/**
	 * set 鬼道
	 */
	public void SetPassiveSkills(List<FightSkillInfo> passiveSkills)
	{
		_passiveSkills = passiveSkills;
	}
	
	/**
	 * 成长阶级
	 */
	public int GrowthLevel
	{
		set { _growthLevel = value; }
	    get { return _growthLevel; }
	}
	
}