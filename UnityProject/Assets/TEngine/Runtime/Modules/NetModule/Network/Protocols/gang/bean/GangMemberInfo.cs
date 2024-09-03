using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队成员信息
 */
public class GangMemberInfo : IMessageSerialize 
{
	//玩家id
	long _playerId;	
	//当前角色id
	int _character;	
	//当前角色阶级
	int _stageLevel;	
	//当前角色成长等级
	int _growthLevel;	
	//玩家等级
	int _level;	
	//玩家名称
	string _name;	
	//玩家战斗力
	int _fightPower;	
	//职位
	byte _job;	
	//今日活跃度
	int _todayActive;	
	//个人总活跃度
	int _totalActive;	
	//离线时间,-1表示在线
	long _offlineTime;	
	//vip等级
	int _vip;	
	//活动次数
	int _activiyTimes;	
	//加入番队时间
	long _joinTime;	
	//所有角色列表
	List<CharacterSyncInfo> _characters = new List<CharacterSyncInfo>();
	//当前助战的角色
	GangSupportCharacterInfo _supportCharacter;	
	//番队经验
	int _gangExp;	
	//番队建设点数
	int _gangBuildPoint;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//玩家id
		SerializeUtils.WriteLong(stream, _playerId);
		//当前角色id
		SerializeUtils.WriteInt(stream, _character);
		//当前角色阶级
		SerializeUtils.WriteInt(stream, _stageLevel);
		//当前角色成长等级
		SerializeUtils.WriteInt(stream, _growthLevel);
		//玩家等级
		SerializeUtils.WriteInt(stream, _level);
		//玩家名称
		SerializeUtils.WriteString(stream, _name);
		//玩家战斗力
		SerializeUtils.WriteInt(stream, _fightPower);
		//职位
		SerializeUtils.WriteByte(stream, _job);
		//今日活跃度
		SerializeUtils.WriteInt(stream, _todayActive);
		//个人总活跃度
		SerializeUtils.WriteInt(stream, _totalActive);
		//离线时间,-1表示在线
		SerializeUtils.WriteLong(stream, _offlineTime);
		//vip等级
		SerializeUtils.WriteInt(stream, _vip);
		//活动次数
		SerializeUtils.WriteInt(stream, _activiyTimes);
		//加入番队时间
		SerializeUtils.WriteLong(stream, _joinTime);
		//所有角色列表
		SerializeUtils.WriteShort(stream, (short)_characters.Count);

		foreach (var element in _characters)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//当前助战的角色
		SerializeUtils.WriteBean(stream, _supportCharacter);
		//番队经验
		SerializeUtils.WriteInt(stream, _gangExp);
		//番队建设点数
		SerializeUtils.WriteInt(stream, _gangBuildPoint);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//玩家id
		_playerId = SerializeUtils.ReadLong(stream);
		//当前角色id
		_character = SerializeUtils.ReadInt(stream);
		//当前角色阶级
		_stageLevel = SerializeUtils.ReadInt(stream);
		//当前角色成长等级
		_growthLevel = SerializeUtils.ReadInt(stream);
		//玩家等级
		_level = SerializeUtils.ReadInt(stream);
		//玩家名称
		_name = SerializeUtils.ReadString(stream);
		//玩家战斗力
		_fightPower = SerializeUtils.ReadInt(stream);
		//职位
		_job = SerializeUtils.ReadByte(stream);
		//今日活跃度
		_todayActive = SerializeUtils.ReadInt(stream);
		//个人总活跃度
		_totalActive = SerializeUtils.ReadInt(stream);
		//离线时间,-1表示在线
		_offlineTime = SerializeUtils.ReadLong(stream);
		//vip等级
		_vip = SerializeUtils.ReadInt(stream);
		//活动次数
		_activiyTimes = SerializeUtils.ReadInt(stream);
		//加入番队时间
		_joinTime = SerializeUtils.ReadLong(stream);
		//所有角色列表
		int _characters_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characters_length; ++i) 
		{
			_characters.Add(SerializeUtils.ReadBean<CharacterSyncInfo>(stream));
		}
		//当前助战的角色
		_supportCharacter = SerializeUtils.ReadBean<GangSupportCharacterInfo>(stream);
		//番队经验
		_gangExp = SerializeUtils.ReadInt(stream);
		//番队建设点数
		_gangBuildPoint = SerializeUtils.ReadInt(stream);
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
	 * 当前角色id
	 */
	public int Character
	{
		set { _character = value; }
	    get { return _character; }
	}
	
	/**
	 * 当前角色阶级
	 */
	public int StageLevel
	{
		set { _stageLevel = value; }
	    get { return _stageLevel; }
	}
	
	/**
	 * 当前角色成长等级
	 */
	public int GrowthLevel
	{
		set { _growthLevel = value; }
	    get { return _growthLevel; }
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
	 * 玩家名称
	 */
	public string Name
	{
		set { _name = value; }
	    get { return _name; }
	}
	
	/**
	 * 玩家战斗力
	 */
	public int FightPower
	{
		set { _fightPower = value; }
	    get { return _fightPower; }
	}
	
	/**
	 * 职位
	 */
	public byte Job
	{
		set { _job = value; }
	    get { return _job; }
	}
	
	/**
	 * 今日活跃度
	 */
	public int TodayActive
	{
		set { _todayActive = value; }
	    get { return _todayActive; }
	}
	
	/**
	 * 个人总活跃度
	 */
	public int TotalActive
	{
		set { _totalActive = value; }
	    get { return _totalActive; }
	}
	
	/**
	 * 离线时间,-1表示在线
	 */
	public long OfflineTime
	{
		set { _offlineTime = value; }
	    get { return _offlineTime; }
	}
	
	/**
	 * vip等级
	 */
	public int Vip
	{
		set { _vip = value; }
	    get { return _vip; }
	}
	
	/**
	 * 活动次数
	 */
	public int ActiviyTimes
	{
		set { _activiyTimes = value; }
	    get { return _activiyTimes; }
	}
	
	/**
	 * 加入番队时间
	 */
	public long JoinTime
	{
		set { _joinTime = value; }
	    get { return _joinTime; }
	}
	
	/**
	 * get 所有角色列表
	 * @return 
	 */
	public List<CharacterSyncInfo> GetCharacters()
	{
		return _characters;
	}
	
	/**
	 * set 所有角色列表
	 */
	public void SetCharacters(List<CharacterSyncInfo> characters)
	{
		_characters = characters;
	}
	
	/**
	 * 当前助战的角色
	 */
	public GangSupportCharacterInfo SupportCharacter
	{
		set { _supportCharacter = value; }
	    get { return _supportCharacter; }
	}
	
	/**
	 * 番队经验
	 */
	public int GangExp
	{
		set { _gangExp = value; }
	    get { return _gangExp; }
	}
	
	/**
	 * 番队建设点数
	 */
	public int GangBuildPoint
	{
		set { _gangBuildPoint = value; }
	    get { return _gangBuildPoint; }
	}
	
}