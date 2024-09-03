using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步关卡中实时血量 message
 */
public class ReqSyncExploreHpMessage : Message 
{
	//玩家剩余血量
	List<SyncHp> _playerList = new List<SyncHp>();
	//boss剩余血量
	List<SyncHp> _bossList = new List<SyncHp>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家剩余血量
		SerializeUtils.WriteShort(stream, (short)_playerList.Count);

		foreach (var element in _playerList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//boss剩余血量
		SerializeUtils.WriteShort(stream, (short)_bossList.Count);

		foreach (var element in _bossList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家剩余血量
		int _playerList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _playerList_length; ++i) 
		{
			_playerList.Add(SerializeUtils.ReadBean<SyncHp>(stream));
		}
		//boss剩余血量
		int _bossList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _bossList_length; ++i) 
		{
			_bossList.Add(SerializeUtils.ReadBean<SyncHp>(stream));
		}
	}
	
	/**
	 * get 玩家剩余血量
	 * @return 
	 */
	public List<SyncHp> GetPlayerList()
	{
		return _playerList;
	}
	
	/**
	 * set 玩家剩余血量
	 */
	public void SetPlayerList(List<SyncHp> playerList)
	{
		_playerList = playerList;
	}
	
	/**
	 * get boss剩余血量
	 * @return 
	 */
	public List<SyncHp> GetBossList()
	{
		return _bossList;
	}
	
	/**
	 * set boss剩余血量
	 */
	public void SetBossList(List<SyncHp> bossList)
	{
		_bossList = bossList;
	}
	
	
	public override int GetId() 
	{
		return 831117;
	}
}