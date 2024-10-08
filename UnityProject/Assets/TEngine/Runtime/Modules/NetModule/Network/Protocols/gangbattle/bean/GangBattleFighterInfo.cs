using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战参战玩家信息
 */
public class GangBattleFighterInfo : IMessageSerialize 
{
	//玩家Id
	long _playerId;	
	//玩家名
	string _playerName;	
	//玩家等级
	int _playerLevel;	
	//小队战斗力
	int _fighting;	
	//已参战次数
	int _fightTimes;	
	//胜利次数
	int _winTimes;	
	//出战角色信息
	List<GangBattleFightCharacterInfo> _fightCharacterInfos = new List<GangBattleFightCharacterInfo>();
	//魂共鸣信息
	List<GangBattleFightSoulResonanceInfo> _soulResonanceInfos = new List<GangBattleFightSoulResonanceInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//玩家Id
		SerializeUtils.WriteLong(stream, _playerId);
		//玩家名
		SerializeUtils.WriteString(stream, _playerName);
		//玩家等级
		SerializeUtils.WriteInt(stream, _playerLevel);
		//小队战斗力
		SerializeUtils.WriteInt(stream, _fighting);
		//已参战次数
		SerializeUtils.WriteInt(stream, _fightTimes);
		//胜利次数
		SerializeUtils.WriteInt(stream, _winTimes);
		//出战角色信息
		SerializeUtils.WriteShort(stream, (short)_fightCharacterInfos.Count);

		foreach (var element in _fightCharacterInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//魂共鸣信息
		SerializeUtils.WriteShort(stream, (short)_soulResonanceInfos.Count);

		foreach (var element in _soulResonanceInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//玩家Id
		_playerId = SerializeUtils.ReadLong(stream);
		//玩家名
		_playerName = SerializeUtils.ReadString(stream);
		//玩家等级
		_playerLevel = SerializeUtils.ReadInt(stream);
		//小队战斗力
		_fighting = SerializeUtils.ReadInt(stream);
		//已参战次数
		_fightTimes = SerializeUtils.ReadInt(stream);
		//胜利次数
		_winTimes = SerializeUtils.ReadInt(stream);
		//出战角色信息
		int _fightCharacterInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _fightCharacterInfos_length; ++i) 
		{
			_fightCharacterInfos.Add(SerializeUtils.ReadBean<GangBattleFightCharacterInfo>(stream));
		}
		//魂共鸣信息
		int _soulResonanceInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _soulResonanceInfos_length; ++i) 
		{
			_soulResonanceInfos.Add(SerializeUtils.ReadBean<GangBattleFightSoulResonanceInfo>(stream));
		}
	}
	
	/**
	 * 玩家Id
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	/**
	 * 玩家名
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
	 * 小队战斗力
	 */
	public int Fighting
	{
		set { _fighting = value; }
	    get { return _fighting; }
	}
	
	/**
	 * 已参战次数
	 */
	public int FightTimes
	{
		set { _fightTimes = value; }
	    get { return _fightTimes; }
	}
	
	/**
	 * 胜利次数
	 */
	public int WinTimes
	{
		set { _winTimes = value; }
	    get { return _winTimes; }
	}
	
	/**
	 * get 出战角色信息
	 * @return 
	 */
	public List<GangBattleFightCharacterInfo> GetFightCharacterInfos()
	{
		return _fightCharacterInfos;
	}
	
	/**
	 * set 出战角色信息
	 */
	public void SetFightCharacterInfos(List<GangBattleFightCharacterInfo> fightCharacterInfos)
	{
		_fightCharacterInfos = fightCharacterInfos;
	}
	
	/**
	 * get 魂共鸣信息
	 * @return 
	 */
	public List<GangBattleFightSoulResonanceInfo> GetSoulResonanceInfos()
	{
		return _soulResonanceInfos;
	}
	
	/**
	 * set 魂共鸣信息
	 */
	public void SetSoulResonanceInfos(List<GangBattleFightSoulResonanceInfo> soulResonanceInfos)
	{
		_soulResonanceInfos = soulResonanceInfos;
	}
	
}