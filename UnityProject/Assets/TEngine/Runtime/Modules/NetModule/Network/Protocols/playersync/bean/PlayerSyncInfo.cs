using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步的玩家信息
 */
public class PlayerSyncInfo : IMessageSerialize 
{
	//玩家id
	long _playerId;	
	//玩家名字
	string _playerName;	
	//玩家等级
	int _playerLevel;	
	//玩家vip等级
	int _vipLevel;	
	//玩家战斗力
	int _fighting;	
	//角色信息
	List<CharacterSyncInfo> _characterSyncInfo = new List<CharacterSyncInfo>();
	//离线时间[-1表示在线,秒值]
	int _offlineTime;	
	//灵压阶级
	int _soulPressStage;	
	//斩魄刀id(皮肤id*10000 + 阶级)
	int _knifeId;	
	//称号id
	int _titleId;	
	//称号等级
	int _titleLevel;	
	//猪的id
	int _petId;	
	
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
		//玩家vip等级
		SerializeUtils.WriteInt(stream, _vipLevel);
		//玩家战斗力
		SerializeUtils.WriteInt(stream, _fighting);
		//角色信息
		SerializeUtils.WriteShort(stream, (short)_characterSyncInfo.Count);

		foreach (var element in _characterSyncInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//离线时间[-1表示在线,秒值]
		SerializeUtils.WriteInt(stream, _offlineTime);
		//灵压阶级
		SerializeUtils.WriteInt(stream, _soulPressStage);
		//斩魄刀id(皮肤id*10000 + 阶级)
		SerializeUtils.WriteInt(stream, _knifeId);
		//称号id
		SerializeUtils.WriteInt(stream, _titleId);
		//称号等级
		SerializeUtils.WriteInt(stream, _titleLevel);
		//猪的id
		SerializeUtils.WriteInt(stream, _petId);
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
		//玩家vip等级
		_vipLevel = SerializeUtils.ReadInt(stream);
		//玩家战斗力
		_fighting = SerializeUtils.ReadInt(stream);
		//角色信息
		int _characterSyncInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterSyncInfo_length; ++i) 
		{
			_characterSyncInfo.Add(SerializeUtils.ReadBean<CharacterSyncInfo>(stream));
		}
		//离线时间[-1表示在线,秒值]
		_offlineTime = SerializeUtils.ReadInt(stream);
		//灵压阶级
		_soulPressStage = SerializeUtils.ReadInt(stream);
		//斩魄刀id(皮肤id*10000 + 阶级)
		_knifeId = SerializeUtils.ReadInt(stream);
		//称号id
		_titleId = SerializeUtils.ReadInt(stream);
		//称号等级
		_titleLevel = SerializeUtils.ReadInt(stream);
		//猪的id
		_petId = SerializeUtils.ReadInt(stream);
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
	 * 玩家vip等级
	 */
	public int VipLevel
	{
		set { _vipLevel = value; }
	    get { return _vipLevel; }
	}
	
	/**
	 * 玩家战斗力
	 */
	public int Fighting
	{
		set { _fighting = value; }
	    get { return _fighting; }
	}
	
	/**
	 * get 角色信息
	 * @return 
	 */
	public List<CharacterSyncInfo> GetCharacterSyncInfo()
	{
		return _characterSyncInfo;
	}
	
	/**
	 * set 角色信息
	 */
	public void SetCharacterSyncInfo(List<CharacterSyncInfo> characterSyncInfo)
	{
		_characterSyncInfo = characterSyncInfo;
	}
	
	/**
	 * 离线时间[-1表示在线,秒值]
	 */
	public int OfflineTime
	{
		set { _offlineTime = value; }
	    get { return _offlineTime; }
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
	 * 斩魄刀id(皮肤id*10000 + 阶级)
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
	 * 猪的id
	 */
	public int PetId
	{
		set { _petId = value; }
	    get { return _petId; }
	}
	
}