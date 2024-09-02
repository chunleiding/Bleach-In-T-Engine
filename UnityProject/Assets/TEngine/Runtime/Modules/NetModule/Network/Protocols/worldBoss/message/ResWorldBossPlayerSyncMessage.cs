using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步世界Boss路人 message
 */
public class ResWorldBossPlayerSyncMessage : Message 
{
	//玩家列表
	List<PlayerSyncInfo> _playerSyncInfo = new List<PlayerSyncInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家列表
		SerializeUtils.WriteShort(stream, (short)_playerSyncInfo.Count);

		foreach (var element in _playerSyncInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家列表
		int _playerSyncInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _playerSyncInfo_length; ++i) 
		{
			_playerSyncInfo.Add(SerializeUtils.ReadBean<PlayerSyncInfo>(stream));
		}
	}
	
	/**
	 * get 玩家列表
	 * @return 
	 */
	public List<PlayerSyncInfo> GetPlayerSyncInfo()
	{
		return _playerSyncInfo;
	}
	
	/**
	 * set 玩家列表
	 */
	public void SetPlayerSyncInfo(List<PlayerSyncInfo> playerSyncInfo)
	{
		_playerSyncInfo = playerSyncInfo;
	}
	
	
	public override int GetId() 
	{
		return 807113;
	}
}