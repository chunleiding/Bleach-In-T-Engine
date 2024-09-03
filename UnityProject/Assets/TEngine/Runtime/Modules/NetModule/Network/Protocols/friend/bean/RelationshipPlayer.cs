using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 关系玩家简要信息
 */
public class RelationshipPlayer : IMessageSerialize 
{
	//玩家编号
	long _playerId;	
	//玩家名称
	string _playerName;	
	//建立关系时的时间
	long _meetTime;	
	//当前使用的角色编号
	int _characterId;	
	//当前角色阶级
	int _stageLevel;	
	//当前角色成长率等级
	int _growthLevel;	
	//玩家等级
	int _level;	
	//离线时间[-1表示在线]
	int _offlineTime;	
	//vip等级
	int _vip;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//玩家编号
		SerializeUtils.WriteLong(stream, _playerId);
		//玩家名称
		SerializeUtils.WriteString(stream, _playerName);
		//建立关系时的时间
		SerializeUtils.WriteLong(stream, _meetTime);
		//当前使用的角色编号
		SerializeUtils.WriteInt(stream, _characterId);
		//当前角色阶级
		SerializeUtils.WriteInt(stream, _stageLevel);
		//当前角色成长率等级
		SerializeUtils.WriteInt(stream, _growthLevel);
		//玩家等级
		SerializeUtils.WriteInt(stream, _level);
		//离线时间[-1表示在线]
		SerializeUtils.WriteInt(stream, _offlineTime);
		//vip等级
		SerializeUtils.WriteInt(stream, _vip);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//玩家编号
		_playerId = SerializeUtils.ReadLong(stream);
		//玩家名称
		_playerName = SerializeUtils.ReadString(stream);
		//建立关系时的时间
		_meetTime = SerializeUtils.ReadLong(stream);
		//当前使用的角色编号
		_characterId = SerializeUtils.ReadInt(stream);
		//当前角色阶级
		_stageLevel = SerializeUtils.ReadInt(stream);
		//当前角色成长率等级
		_growthLevel = SerializeUtils.ReadInt(stream);
		//玩家等级
		_level = SerializeUtils.ReadInt(stream);
		//离线时间[-1表示在线]
		_offlineTime = SerializeUtils.ReadInt(stream);
		//vip等级
		_vip = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 玩家编号
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	/**
	 * 玩家名称
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * 建立关系时的时间
	 */
	public long MeetTime
	{
		set { _meetTime = value; }
	    get { return _meetTime; }
	}
	
	/**
	 * 当前使用的角色编号
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
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
	 * 当前角色成长率等级
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
	 * 离线时间[-1表示在线]
	 */
	public int OfflineTime
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
	
}