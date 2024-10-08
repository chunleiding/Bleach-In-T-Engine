using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家战斗属性同步 message
 */
public class ResPlayerFightAttributeMessage : Message 
{
	//灵魂共鸣属性
	GlobalBattleAttributeInfo _gbAttributeInfo;	
	//战斗属性
	List<CharacterAttributeInfo> _characterAttributeInfo = new List<CharacterAttributeInfo>();
    //场景被动技能
    List<FightSkillInfo> _sceneSkill = new List<FightSkillInfo>();
    //书院技能书属性
    CollegeAttributeInfo _collegeAttributeInfo;	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//灵魂共鸣属性
		SerializeUtils.WriteBean(stream, _gbAttributeInfo);
		//战斗属性
		SerializeUtils.WriteShort(stream, (short)_characterAttributeInfo.Count);

		foreach (var element in _characterAttributeInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}

        //场景被动技能
        SerializeUtils.WriteShort(stream, (short)_sceneSkill.Count);

        foreach (var element in _sceneSkill)
        {
            SerializeUtils.WriteBean(stream, element);
        }

        //场景被动技能
        int _sceneSkill_length = SerializeUtils.ReadShort(stream);
        for (int i = 0; i < _sceneSkill_length; ++i)
        {
            _sceneSkill.Add(SerializeUtils.ReadBean<FightSkillInfo>(stream));
        }
        //书院技能书属性
        SerializeUtils.WriteBean(stream, _collegeAttributeInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//灵魂共鸣属性
		_gbAttributeInfo = SerializeUtils.ReadBean<GlobalBattleAttributeInfo>(stream);
		//战斗属性
		int _characterAttributeInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterAttributeInfo_length; ++i) 
		{
			_characterAttributeInfo.Add(SerializeUtils.ReadBean<CharacterAttributeInfo>(stream));
		}

        //场景被动技能
        int _sceneSkill_length = SerializeUtils.ReadShort(stream);
        for (int i = 0; i < _sceneSkill_length; ++i)
        {
            _sceneSkill.Add(SerializeUtils.ReadBean<FightSkillInfo>(stream));
        }
        //书院技能书属性
        _collegeAttributeInfo = SerializeUtils.ReadBean<CollegeAttributeInfo>(stream);
	}
	
	/**
	 * 灵魂共鸣属性
	 */
	public GlobalBattleAttributeInfo GbAttributeInfo
	{
		set { _gbAttributeInfo = value; }
	    get { return _gbAttributeInfo; }
	}
	
	/**
	 * get 战斗属性
	 * @return 
	 */
	public List<CharacterAttributeInfo> GetCharacterAttributeInfo()
	{
		return _characterAttributeInfo;
	}
	
	/**
	 * set 战斗属性
	 */
	public void SetCharacterAttributeInfo(List<CharacterAttributeInfo> characterAttributeInfo)
	{
		_characterAttributeInfo = characterAttributeInfo;
	}

    /**
     * get 场景被动技能
     * @return 
     */
    public List<FightSkillInfo> GetSceneSkill()
    {
        return _sceneSkill;
    }

    /**
     * set 场景被动技能
     */
    public void SetSceneSkill(List<FightSkillInfo> sceneSkill)
    {
        _sceneSkill = sceneSkill;
    }
    /**
 * 书院技能书属性
 */
    public CollegeAttributeInfo CollegeAttributeInfo
    {
        set { _collegeAttributeInfo = value; }
        get { return _collegeAttributeInfo; }
    }
	public override int GetId() 
	{
		return 400204;
	}
}