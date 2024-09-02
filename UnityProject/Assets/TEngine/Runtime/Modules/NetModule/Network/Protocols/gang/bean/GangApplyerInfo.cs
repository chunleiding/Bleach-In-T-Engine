using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队申请者信息
 */
public class GangApplyerInfo : IMessageSerialize 
{
	//玩家id
	long _playerId;	
	//当前角色id
	int _character;	
	//当前角色阶级
	int _stageLevel;	
	//角色成长等级
	int _growthLevel;	
	//玩家等级
	int _level;	
	//玩家vip等级
	int _vipLevel;	
	//玩家名称
	string _name;	
	//玩家战斗力
	int _fightPower;	
	//离线时间[-1表示在线,毫秒值]
	int _offlineTime;	
	
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
		//角色成长等级
		SerializeUtils.WriteInt(stream, _growthLevel);
		//玩家等级
		SerializeUtils.WriteInt(stream, _level);
		//玩家vip等级
		SerializeUtils.WriteInt(stream, _vipLevel);
		//玩家名称
		SerializeUtils.WriteString(stream, _name);
		//玩家战斗力
		SerializeUtils.WriteInt(stream, _fightPower);
		//离线时间[-1表示在线,毫秒值]
		SerializeUtils.WriteInt(stream, _offlineTime);
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
		//角色成长等级
		_growthLevel = SerializeUtils.ReadInt(stream);
		//玩家等级
		_level = SerializeUtils.ReadInt(stream);
		//玩家vip等级
		_vipLevel = SerializeUtils.ReadInt(stream);
		//玩家名称
		_name = SerializeUtils.ReadString(stream);
		//玩家战斗力
		_fightPower = SerializeUtils.ReadInt(stream);
		//离线时间[-1表示在线,毫秒值]
		_offlineTime = SerializeUtils.ReadInt(stream);
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
	 * 角色成长等级
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
	 * 玩家vip等级
	 */
	public int VipLevel
	{
		set { _vipLevel = value; }
	    get { return _vipLevel; }
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
	 * 离线时间[-1表示在线,毫秒值]
	 */
	public int OfflineTime
	{
		set { _offlineTime = value; }
	    get { return _offlineTime; }
	}
	
}