using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色战斗属性信息
 */
public class CharacterAttributeInfo : IMessageSerialize 
{
	//角色id
	int _characterId;	
	//角色阶级
	int _stage;	
	//血量
	int _hp;	
	//满血血量
	int _maxHp;	
	//灵力>0：角色id
	int _mp;	
	//攻击力
	int _atk;	
	//防御力
	int _def;	
	//耐力
	int _sta;	
	//暴击率
	int _crit;	
	//基础灵力恢复速度
	int _mpRecoverSpeed;	
	//基础灵力受击恢复速度
	int _mpHurtRecover;	
	//基础灵力攻击恢复速度
	int _mpHitRecover;	
	//基础灵力消耗比例
	int _mpCostRatio;	
	//耐力恢复速度
	int _spRecoverSpeedPct;	
	//耐力恢复时间间隔
	int _spRecoverInterval;	
	//冲刺耐力消耗比例, 相对于最大耐力
	int _spDashCostPct;	
	//防御耐力消耗比例, 相对于伤害量
	int _spDefenceCostPct;	
	//基础耐力消耗比例
	int _spCostRatio;	
	//最大韧性
	int _maxTenacity;	
	//最大浮空值
	int _maxFloatingValue;	
	//战斗力
	int _fightPower;	
	//角色成长等级
	int _growthLevel;	
	//主动技能
	List<SkillInfo> _activeSkills = new List<SkillInfo>();
	//被动技能（灵魂能力）
	List<FightSkillInfo> _passiveSkills = new List<FightSkillInfo>();
	//援护支援鬼道
	List<FightSkillInfo> _assistSkills = new List<FightSkillInfo>();
	//灵魂共鸣技能
	List<FightSkillInfo> _resonanceSkills = new List<FightSkillInfo>();
	//克制关系受伤增加比例（万分比分子）
	int _restrainInjuredRatio;	
	//灵压阶级
	int _soulPressStage;	
	//灵骸阶级
	int _skeletonStage;	
	//灵骸技能
	List<FightSkillInfo> _skeletonSkill = new List<FightSkillInfo>();
	//静血量
	int _staticHp;	
	//最大静血
	int _maxStaticHp;	
	//	斩魄刀ID(斩魄刀皮肤id*10000 + 斩魄刀阶级)
	int _knifeId;	
	//称号id
	int _titleId;	
	//称号等级
	int _titleLevel;	
	//宠物猪id
	int _pigId;	
	//宠物技能等级
	List<FightSkillInfo> _petSkillInfo = new List<FightSkillInfo>();
    //书院等级
    int _collegeStage;
    //书院技能书
    List<FightSkillInfo> _collegeBookInfo = new List<FightSkillInfo>();
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//角色阶级
		SerializeUtils.WriteInt(stream, _stage);
		//血量
		SerializeUtils.WriteInt(stream, _hp);
		//满血血量
		SerializeUtils.WriteInt(stream, _maxHp);
		//灵力>0：角色id
		SerializeUtils.WriteInt(stream, _mp);
		//攻击力
		SerializeUtils.WriteInt(stream, _atk);
		//防御力
		SerializeUtils.WriteInt(stream, _def);
		//耐力
		SerializeUtils.WriteInt(stream, _sta);
		//暴击率
		SerializeUtils.WriteInt(stream, _crit);
		//基础灵力恢复速度
		SerializeUtils.WriteInt(stream, _mpRecoverSpeed);
		//基础灵力受击恢复速度
		SerializeUtils.WriteInt(stream, _mpHurtRecover);
		//基础灵力攻击恢复速度
		SerializeUtils.WriteInt(stream, _mpHitRecover);
		//基础灵力消耗比例
		SerializeUtils.WriteInt(stream, _mpCostRatio);
		//耐力恢复速度
		SerializeUtils.WriteInt(stream, _spRecoverSpeedPct);
		//耐力恢复时间间隔
		SerializeUtils.WriteInt(stream, _spRecoverInterval);
		//冲刺耐力消耗比例, 相对于最大耐力
		SerializeUtils.WriteInt(stream, _spDashCostPct);
		//防御耐力消耗比例, 相对于伤害量
		SerializeUtils.WriteInt(stream, _spDefenceCostPct);
		//基础耐力消耗比例
		SerializeUtils.WriteInt(stream, _spCostRatio);
		//最大韧性
		SerializeUtils.WriteInt(stream, _maxTenacity);
		//最大浮空值
		SerializeUtils.WriteInt(stream, _maxFloatingValue);
		//战斗力
		SerializeUtils.WriteInt(stream, _fightPower);
		//角色成长等级
		SerializeUtils.WriteInt(stream, _growthLevel);
		//主动技能
		SerializeUtils.WriteShort(stream, (short)_activeSkills.Count);

		foreach (var element in _activeSkills)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//被动技能（灵魂能力）
		SerializeUtils.WriteShort(stream, (short)_passiveSkills.Count);

		foreach (var element in _passiveSkills)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//援护支援鬼道
		SerializeUtils.WriteShort(stream, (short)_assistSkills.Count);

		foreach (var element in _assistSkills)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//灵魂共鸣技能
		SerializeUtils.WriteShort(stream, (short)_resonanceSkills.Count);

		foreach (var element in _resonanceSkills)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//克制关系受伤增加比例（万分比分子）
		SerializeUtils.WriteInt(stream, _restrainInjuredRatio);
		//灵压阶级
		SerializeUtils.WriteInt(stream, _soulPressStage);
		//灵骸阶级
		SerializeUtils.WriteInt(stream, _skeletonStage);
		//灵骸技能
		SerializeUtils.WriteShort(stream, (short)_skeletonSkill.Count);

		foreach (var element in _skeletonSkill)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//静血量
		SerializeUtils.WriteInt(stream, _staticHp);
		//最大静血
		SerializeUtils.WriteInt(stream, _maxStaticHp);
		//	斩魄刀ID(斩魄刀皮肤id*10000 + 斩魄刀阶级)
		SerializeUtils.WriteInt(stream, _knifeId);
		//称号id
		SerializeUtils.WriteInt(stream, _titleId);
		//称号等级
		SerializeUtils.WriteInt(stream, _titleLevel);
		//宠物猪id
		SerializeUtils.WriteInt(stream, _pigId);
		//宠物技能等级
		SerializeUtils.WriteShort(stream, (short)_petSkillInfo.Count);
        //书院等级
        SerializeUtils.WriteInt(stream, _collegeStage);
        //书院技能书
        SerializeUtils.WriteShort(stream, (short)_collegeBookInfo.Count);

        foreach (var element in _collegeBookInfo)
        {
            SerializeUtils.WriteBean(stream, element);
        }
		foreach (var element in _petSkillInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//角色阶级
		_stage = SerializeUtils.ReadInt(stream);
		//血量
		_hp = SerializeUtils.ReadInt(stream);
		//满血血量
		_maxHp = SerializeUtils.ReadInt(stream);
		//灵力>0：角色id
		_mp = SerializeUtils.ReadInt(stream);
		//攻击力
		_atk = SerializeUtils.ReadInt(stream);
		//防御力
		_def = SerializeUtils.ReadInt(stream);
		//耐力
		_sta = SerializeUtils.ReadInt(stream);
		//暴击率
		_crit = SerializeUtils.ReadInt(stream);
		//基础灵力恢复速度
		_mpRecoverSpeed = SerializeUtils.ReadInt(stream);
		//基础灵力受击恢复速度
		_mpHurtRecover = SerializeUtils.ReadInt(stream);
		//基础灵力攻击恢复速度
		_mpHitRecover = SerializeUtils.ReadInt(stream);
		//基础灵力消耗比例
		_mpCostRatio = SerializeUtils.ReadInt(stream);
		//耐力恢复速度
		_spRecoverSpeedPct = SerializeUtils.ReadInt(stream);
		//耐力恢复时间间隔
		_spRecoverInterval = SerializeUtils.ReadInt(stream);
		//冲刺耐力消耗比例, 相对于最大耐力
		_spDashCostPct = SerializeUtils.ReadInt(stream);
		//防御耐力消耗比例, 相对于伤害量
		_spDefenceCostPct = SerializeUtils.ReadInt(stream);
		//基础耐力消耗比例
		_spCostRatio = SerializeUtils.ReadInt(stream);
		//最大韧性
		_maxTenacity = SerializeUtils.ReadInt(stream);
		//最大浮空值
		_maxFloatingValue = SerializeUtils.ReadInt(stream);
		//战斗力
		_fightPower = SerializeUtils.ReadInt(stream);
		//角色成长等级
		_growthLevel = SerializeUtils.ReadInt(stream);
		//主动技能
		int _activeSkills_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _activeSkills_length; ++i) 
		{
			_activeSkills.Add(SerializeUtils.ReadBean<SkillInfo>(stream));
		}
		//被动技能（灵魂能力）
		int _passiveSkills_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _passiveSkills_length; ++i) 
		{
			_passiveSkills.Add(SerializeUtils.ReadBean<FightSkillInfo>(stream));
		}
		//援护支援鬼道
		int _assistSkills_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _assistSkills_length; ++i) 
		{
			_assistSkills.Add(SerializeUtils.ReadBean<FightSkillInfo>(stream));
		}
		//灵魂共鸣技能
		int _resonanceSkills_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _resonanceSkills_length; ++i) 
		{
			_resonanceSkills.Add(SerializeUtils.ReadBean<FightSkillInfo>(stream));
		}
		//克制关系受伤增加比例（万分比分子）
		_restrainInjuredRatio = SerializeUtils.ReadInt(stream);
		//灵压阶级
		_soulPressStage = SerializeUtils.ReadInt(stream);
		//灵骸阶级
		_skeletonStage = SerializeUtils.ReadInt(stream);
		//灵骸技能
		int _skeletonSkill_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _skeletonSkill_length; ++i) 
		{
			_skeletonSkill.Add(SerializeUtils.ReadBean<FightSkillInfo>(stream));
		}
		//静血量
		_staticHp = SerializeUtils.ReadInt(stream);
		//最大静血
		_maxStaticHp = SerializeUtils.ReadInt(stream);
		//	斩魄刀ID(斩魄刀皮肤id*10000 + 斩魄刀阶级)
		_knifeId = SerializeUtils.ReadInt(stream);
		//称号id
		_titleId = SerializeUtils.ReadInt(stream);
		//称号等级
		_titleLevel = SerializeUtils.ReadInt(stream);
		//宠物猪id
		_pigId = SerializeUtils.ReadInt(stream);
		//宠物技能等级
		int _petSkillInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _petSkillInfo_length; ++i) 
		{
			_petSkillInfo.Add(SerializeUtils.ReadBean<FightSkillInfo>(stream));
		}
        //书院等级
        _collegeStage = SerializeUtils.ReadInt(stream);
        //书院技能书
        int _collegeBookInfo_length = SerializeUtils.ReadShort(stream);
        for (int i = 0; i < _collegeBookInfo_length; ++i)
        {
            _collegeBookInfo.Add(SerializeUtils.ReadBean<FightSkillInfo>(stream));
        }
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
	public int Stage
	{
		set { _stage = value; }
	    get { return _stage; }
	}
	
	/**
	 * 血量
	 */
	public int Hp
	{
		set { _hp = value; }
	    get { return _hp; }
	}
	
	/**
	 * 满血血量
	 */
	public int MaxHp
	{
		set { _maxHp = value; }
	    get { return _maxHp; }
	}
	
	/**
	 * 灵力>0：角色id
	 */
	public int Mp
	{
		set { _mp = value; }
	    get { return _mp; }
	}
	
	/**
	 * 攻击力
	 */
	public int Atk
	{
		set { _atk = value; }
	    get { return _atk; }
	}
	
	/**
	 * 防御力
	 */
	public int Def
	{
		set { _def = value; }
	    get { return _def; }
	}
	
	/**
	 * 耐力
	 */
	public int Sta
	{
		set { _sta = value; }
	    get { return _sta; }
	}
	
	/**
	 * 暴击率
	 */
	public int Crit
	{
		set { _crit = value; }
	    get { return _crit; }
	}
	
	/**
	 * 基础灵力恢复速度
	 */
	public int MpRecoverSpeed
	{
		set { _mpRecoverSpeed = value; }
	    get { return _mpRecoverSpeed; }
	}
	
	/**
	 * 基础灵力受击恢复速度
	 */
	public int MpHurtRecover
	{
		set { _mpHurtRecover = value; }
	    get { return _mpHurtRecover; }
	}
	
	/**
	 * 基础灵力攻击恢复速度
	 */
	public int MpHitRecover
	{
		set { _mpHitRecover = value; }
	    get { return _mpHitRecover; }
	}
	
	/**
	 * 基础灵力消耗比例
	 */
	public int MpCostRatio
	{
		set { _mpCostRatio = value; }
	    get { return _mpCostRatio; }
	}
	
	/**
	 * 耐力恢复速度
	 */
	public int SpRecoverSpeedPct
	{
		set { _spRecoverSpeedPct = value; }
	    get { return _spRecoverSpeedPct; }
	}
	
	/**
	 * 耐力恢复时间间隔
	 */
	public int SpRecoverInterval
	{
		set { _spRecoverInterval = value; }
	    get { return _spRecoverInterval; }
	}
	
	/**
	 * 冲刺耐力消耗比例, 相对于最大耐力
	 */
	public int SpDashCostPct
	{
		set { _spDashCostPct = value; }
	    get { return _spDashCostPct; }
	}
	
	/**
	 * 防御耐力消耗比例, 相对于伤害量
	 */
	public int SpDefenceCostPct
	{
		set { _spDefenceCostPct = value; }
	    get { return _spDefenceCostPct; }
	}
	
	/**
	 * 基础耐力消耗比例
	 */
	public int SpCostRatio
	{
		set { _spCostRatio = value; }
	    get { return _spCostRatio; }
	}
	
	/**
	 * 最大韧性
	 */
	public int MaxTenacity
	{
		set { _maxTenacity = value; }
	    get { return _maxTenacity; }
	}
	
	/**
	 * 最大浮空值
	 */
	public int MaxFloatingValue
	{
		set { _maxFloatingValue = value; }
	    get { return _maxFloatingValue; }
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
	 * 角色成长等级
	 */
	public int GrowthLevel
	{
		set { _growthLevel = value; }
	    get { return _growthLevel; }
	}
	
	/**
	 * get 主动技能
	 * @return 
	 */
	public List<SkillInfo> GetActiveSkills()
	{
		return _activeSkills;
	}
	
	/**
	 * set 主动技能
	 */
	public void SetActiveSkills(List<SkillInfo> activeSkills)
	{
		_activeSkills = activeSkills;
	}
	
	/**
	 * get 被动技能（灵魂能力）
	 * @return 
	 */
	public List<FightSkillInfo> GetPassiveSkills()
	{
		return _passiveSkills;
	}
	
	/**
	 * set 被动技能（灵魂能力）
	 */
	public void SetPassiveSkills(List<FightSkillInfo> passiveSkills)
	{
		_passiveSkills = passiveSkills;
	}
	
	/**
	 * get 援护支援鬼道
	 * @return 
	 */
	public List<FightSkillInfo> GetAssistSkills()
	{
		return _assistSkills;
	}
	
	/**
	 * set 援护支援鬼道
	 */
	public void SetAssistSkills(List<FightSkillInfo> assistSkills)
	{
		_assistSkills = assistSkills;
	}
	
	/**
	 * get 灵魂共鸣技能
	 * @return 
	 */
	public List<FightSkillInfo> GetResonanceSkills()
	{
		return _resonanceSkills;
	}
	
	/**
	 * set 灵魂共鸣技能
	 */
	public void SetResonanceSkills(List<FightSkillInfo> resonanceSkills)
	{
		_resonanceSkills = resonanceSkills;
	}
	
	/**
	 * 克制关系受伤增加比例（万分比分子）
	 */
	public int RestrainInjuredRatio
	{
		set { _restrainInjuredRatio = value; }
	    get { return _restrainInjuredRatio; }
	}
	
	/**
	 * 灵压阶级
	 */
	public int SoulPressStage
	{
		set { _soulPressStage = value; }
	    get { return _soulPressStage; }
	}
	
	/**
	 * 灵骸阶级
	 */
	public int SkeletonStage
	{
		set { _skeletonStage = value; }
	    get { return _skeletonStage; }
	}
	
	/**
	 * get 灵骸技能
	 * @return 
	 */
	public List<FightSkillInfo> GetSkeletonSkill()
	{
		return _skeletonSkill;
	}
	
	/**
	 * set 灵骸技能
	 */
	public void SetSkeletonSkill(List<FightSkillInfo> skeletonSkill)
	{
		_skeletonSkill = skeletonSkill;
	}
	
	/**
	 * 静血量
	 */
	public int StaticHp
	{
		set { _staticHp = value; }
	    get { return _staticHp; }
	}
	
	/**
	 * 最大静血
	 */
	public int MaxStaticHp
	{
		set { _maxStaticHp = value; }
	    get { return _maxStaticHp; }
	}
	
	/**
	 * 	斩魄刀ID(斩魄刀皮肤id*10000 + 斩魄刀阶级)
	 */
	public int KnifeId
	{
		set { _knifeId = value; }
	    get { return _knifeId; }
	}
	
	/**
	 * 称号id
	 */
	public int TitleId
	{
		set { _titleId = value; }
	    get { return _titleId; }
	}
	
	/**
	 * 称号等级
	 */
	public int TitleLevel
	{
		set { _titleLevel = value; }
	    get { return _titleLevel; }
	}
	
	/**
	 * 宠物猪id
	 */
	public int PigId
	{
		set { _pigId = value; }
	    get { return _pigId; }
	}
	
	/**
	 * get 宠物技能等级
	 * @return 
	 */
	public List<FightSkillInfo> GetPetSkillInfo()
	{
		return _petSkillInfo;
	}
	
	/**
	 * set 宠物技能等级
	 */
	public void SetPetSkillInfo(List<FightSkillInfo> petSkillInfo)
	{
		_petSkillInfo = petSkillInfo;
	}
    /**
 * 书院等级
 */
    public int CollegeStage
    {
        set { _collegeStage = value; }
        get { return _collegeStage; }
    }

    /**
     * get 书院技能书
     * @return 
     */
    public List<FightSkillInfo> GetCollegeBookInfo()
    {
        return _collegeBookInfo;
    }

    /**
     * set 书院技能书
     */
    public void SetCollegeBookInfo(List<FightSkillInfo> collegeBookInfo)
    {
        _collegeBookInfo = collegeBookInfo;
    }
}