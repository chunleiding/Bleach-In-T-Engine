using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 地狱蝶对手信息
 */
public class ButterflyOpponentInfo : IMessageSerialize 
{
	//玩家id
	long _playerId;	
	//玩家名字
	string _playerName;	
	//玩家等级
	int _playerLevel;	
	//玩家地狱蝶数量
	int _butterflyCount;	
	//番队名字
	string _gangName;	
	//对手角色列表
	List<ArenaFightCharacterInfo> _oppoCharacterInfos = new List<ArenaFightCharacterInfo>();
	//灵魂共鸣技能
	List<SoulResonance> _resonanceSkills = new List<SoulResonance>();
	//灵骸阶级
	int _skeletonStage;
    //真灵院书籍列表
    List<CollegeBook> _collegeBookList = new List<CollegeBook>();
    //书院等级
    int _collegeStage;	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//玩家id
		SerializeUtils.WriteLong(stream, _playerId);
		//玩家名字
		SerializeUtils.WriteString(stream, _playerName);
		//玩家等级
		SerializeUtils.WriteInt(stream, _playerLevel);
		//玩家地狱蝶数量
		SerializeUtils.WriteInt(stream, _butterflyCount);
		//番队名字
		SerializeUtils.WriteString(stream, _gangName);
		//对手角色列表
		SerializeUtils.WriteShort(stream, (short)_oppoCharacterInfos.Count);

		foreach (var element in _oppoCharacterInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//灵魂共鸣技能
		SerializeUtils.WriteShort(stream, (short)_resonanceSkills.Count);

		foreach (var element in _resonanceSkills)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//灵骸阶级
		SerializeUtils.WriteInt(stream, _skeletonStage);
        //真灵院书籍列表
        SerializeUtils.WriteShort(stream, (short)_collegeBookList.Count);

        foreach (var element in _collegeBookList)
        {
            SerializeUtils.WriteBean(stream, element);
        }
        //书院等级
        SerializeUtils.WriteInt(stream, _collegeStage);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//玩家id
		_playerId = SerializeUtils.ReadLong(stream);
		//玩家名字
		_playerName = SerializeUtils.ReadString(stream);
		//玩家等级
		_playerLevel = SerializeUtils.ReadInt(stream);
		//玩家地狱蝶数量
		_butterflyCount = SerializeUtils.ReadInt(stream);
		//番队名字
		_gangName = SerializeUtils.ReadString(stream);
		//对手角色列表
		int _oppoCharacterInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _oppoCharacterInfos_length; ++i) 
		{
			_oppoCharacterInfos.Add(SerializeUtils.ReadBean<ArenaFightCharacterInfo>(stream));
		}
		//灵魂共鸣技能
		int _resonanceSkills_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _resonanceSkills_length; ++i) 
		{
			_resonanceSkills.Add(SerializeUtils.ReadBean<SoulResonance>(stream));
		}
		//灵骸阶级
		_skeletonStage = SerializeUtils.ReadInt(stream);
        //真灵院书籍列表
        int _collegeBookList_length = SerializeUtils.ReadShort(stream);
        for (int i = 0; i < _collegeBookList_length; ++i)
        {
            _collegeBookList.Add(SerializeUtils.ReadBean<CollegeBook>(stream));
        }
        //书院等级
        _collegeStage = SerializeUtils.ReadInt(stream);
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
	 * 玩家名字
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * 玩家等级
	 */
	public int PlayerLevel
	{
		set { _playerLevel = value; }
	    get { return _playerLevel; }
	}
	
	/**
	 * 玩家地狱蝶数量
	 */
	public int ButterflyCount
	{
		set { _butterflyCount = value; }
	    get { return _butterflyCount; }
	}
	
	/**
	 * 番队名字
	 */
	public string GangName
	{
		set { _gangName = value; }
	    get { return _gangName; }
	}
	
	/**
	 * get 对手角色列表
	 * @return 
	 */
	public List<ArenaFightCharacterInfo> GetOppoCharacterInfos()
	{
		return _oppoCharacterInfos;
	}
	
	/**
	 * set 对手角色列表
	 */
	public void SetOppoCharacterInfos(List<ArenaFightCharacterInfo> oppoCharacterInfos)
	{
		_oppoCharacterInfos = oppoCharacterInfos;
	}
	
	/**
	 * get 灵魂共鸣技能
	 * @return 
	 */
	public List<SoulResonance> GetResonanceSkills()
	{
		return _resonanceSkills;
	}
	
	/**
	 * set 灵魂共鸣技能
	 */
	public void SetResonanceSkills(List<SoulResonance> resonanceSkills)
	{
		_resonanceSkills = resonanceSkills;
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
 * get 真灵院书籍列表
 * @return 
 */
    public List<CollegeBook> GetCollegeBookList()
    {
        return _collegeBookList;
    }

    /**
     * set 真灵院书籍列表
     */
    public void SetCollegeBookList(List<CollegeBook> collegeBookList)
    {
        _collegeBookList = collegeBookList;
    }

    /**
     * 书院等级
     */
    public int CollegeStage
    {
        set { _collegeStage = value; }
        get { return _collegeStage; }
    }
}