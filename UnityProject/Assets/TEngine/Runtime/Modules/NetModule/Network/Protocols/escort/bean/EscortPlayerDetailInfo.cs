using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家货物详细信息
 */
public class EscortPlayerDetailInfo : IMessageSerialize 
{
	//玩家名字
	string _playerName;	
	//被打劫次数
	int _robNumber;	
	//玩家ID
	long _playerID;	
	//玩家的级数
	int _level;	
	//玩家服务器ID
	int _serverId;	
	//离运送货物结束时间
	int _overTime;	
	//魂共鸣列表
	List<SoulResonance> _resonanceSkills = new List<SoulResonance>();
	//角色信息
	List<ArenaFightCharacterInfo> _characterInfos = new List<ArenaFightCharacterInfo>();
	//奖励id
	int _itemId;	
	//道具数量
	int _itemCount;	
	//灵骸阶级
	int _skeletonStage;	
	//护送货物的星级
	int _star;
    //书籍列表
    List<CollegeBook> _collegeBookList = new List<CollegeBook>();
    //书院阶级
    int _collegeStage;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//玩家名字
		SerializeUtils.WriteString(stream, _playerName);
		//被打劫次数
		SerializeUtils.WriteInt(stream, _robNumber);
		//玩家ID
		SerializeUtils.WriteLong(stream, _playerID);
		//玩家的级数
		SerializeUtils.WriteInt(stream, _level);
		//玩家服务器ID
		SerializeUtils.WriteInt(stream, _serverId);
		//离运送货物结束时间
		SerializeUtils.WriteInt(stream, _overTime);
		//魂共鸣列表
		SerializeUtils.WriteShort(stream, (short)_resonanceSkills.Count);

		foreach (var element in _resonanceSkills)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//角色信息
		SerializeUtils.WriteShort(stream, (short)_characterInfos.Count);

		foreach (var element in _characterInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//奖励id
		SerializeUtils.WriteInt(stream, _itemId);
		//道具数量
		SerializeUtils.WriteInt(stream, _itemCount);
		//灵骸阶级
		SerializeUtils.WriteInt(stream, _skeletonStage);
		//护送货物的星级
		SerializeUtils.WriteInt(stream, _star);
        //书籍列表
        SerializeUtils.WriteShort(stream, (short)_collegeBookList.Count);

        foreach (var element in _collegeBookList)
        {
            SerializeUtils.WriteBean(stream, element);
        }
        //书院阶级
        SerializeUtils.WriteInt(stream, _collegeStage);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//玩家名字
		_playerName = SerializeUtils.ReadString(stream);
		//被打劫次数
		_robNumber = SerializeUtils.ReadInt(stream);
		//玩家ID
		_playerID = SerializeUtils.ReadLong(stream);
		//玩家的级数
		_level = SerializeUtils.ReadInt(stream);
		//玩家服务器ID
		_serverId = SerializeUtils.ReadInt(stream);
		//离运送货物结束时间
		_overTime = SerializeUtils.ReadInt(stream);
		//魂共鸣列表
		int _resonanceSkills_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _resonanceSkills_length; ++i) 
		{
			_resonanceSkills.Add(SerializeUtils.ReadBean<SoulResonance>(stream));
		}
		//角色信息
		int _characterInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterInfos_length; ++i) 
		{
			_characterInfos.Add(SerializeUtils.ReadBean<ArenaFightCharacterInfo>(stream));
		}
		//奖励id
		_itemId = SerializeUtils.ReadInt(stream);
		//道具数量
		_itemCount = SerializeUtils.ReadInt(stream);
		//灵骸阶级
		_skeletonStage = SerializeUtils.ReadInt(stream);
		//护送货物的星级
		_star = SerializeUtils.ReadInt(stream);
        //书籍列表
        int _collegeBookList_length = SerializeUtils.ReadShort(stream);
        for (int i = 0; i < _collegeBookList_length; ++i)
        {
            _collegeBookList.Add(SerializeUtils.ReadBean<CollegeBook>(stream));
        }
        //书院阶级
        _collegeStage = SerializeUtils.ReadInt(stream);
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
	 * 被打劫次数
	 */
	public int RobNumber
	{
		set { _robNumber = value; }
	    get { return _robNumber; }
	}
	
	/**
	 * 玩家ID
	 */
	public long PlayerID
	{
		set { _playerID = value; }
	    get { return _playerID; }
	}
	
	/**
	 * 玩家的级数
	 */
	public int Level
	{
		set { _level = value; }
	    get { return _level; }
	}
	
	/**
	 * 玩家服务器ID
	 */
	public int ServerId
	{
		set { _serverId = value; }
	    get { return _serverId; }
	}
	
	/**
	 * 离运送货物结束时间
	 */
	public int OverTime
	{
		set { _overTime = value; }
	    get { return _overTime; }
	}
	
	/**
	 * get 魂共鸣列表
	 * @return 
	 */
	public List<SoulResonance> GetResonanceSkills()
	{
		return _resonanceSkills;
	}
	
	/**
	 * set 魂共鸣列表
	 */
	public void SetResonanceSkills(List<SoulResonance> resonanceSkills)
	{
		_resonanceSkills = resonanceSkills;
	}
	
	/**
	 * get 角色信息
	 * @return 
	 */
	public List<ArenaFightCharacterInfo> GetCharacterInfos()
	{
		return _characterInfos;
	}
	
	/**
	 * set 角色信息
	 */
	public void SetCharacterInfos(List<ArenaFightCharacterInfo> characterInfos)
	{
		_characterInfos = characterInfos;
	}
	
	/**
	 * 奖励id
	 */
	public int ItemId
	{
		set { _itemId = value; }
	    get { return _itemId; }
	}
	
	/**
	 * 道具数量
	 */
	public int ItemCount
	{
		set { _itemCount = value; }
	    get { return _itemCount; }
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
	 * 护送货物的星级
	 */
	public int Star
	{
		set { _star = value; }
	    get { return _star; }
	}
    /**
 * get 书籍列表
 * @return 
 */
    public List<CollegeBook> GetCollegeBookList()
    {
        return _collegeBookList;
    }

    /**
     * set 书籍列表
     */
    public void SetCollegeBookList(List<CollegeBook> collegeBookList)
    {
        _collegeBookList = collegeBookList;
    }

    /**
     * 书院阶级
     */
    public int CollegeStage
    {
        set { _collegeStage = value; }
        get { return _collegeStage; }
    }
}