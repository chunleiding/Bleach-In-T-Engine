using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 *  message
 */
public class ResPlayerSyncMessage : Message 
{
	//
	List<PlayerSyncInfo> _playerSyncInfo = new List<PlayerSyncInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//
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
		//
		int _playerSyncInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _playerSyncInfo_length; ++i) 
		{
			_playerSyncInfo.Add(SerializeUtils.ReadBean<PlayerSyncInfo>(stream));
		}
	}
	
	/**
	 * get 
	 * @return 
	 */
	public List<PlayerSyncInfo> GetPlayerSyncInfo()
	{
		return _playerSyncInfo;
	}
	
	/**
	 * set 
	 */
	public void SetPlayerSyncInfo(List<PlayerSyncInfo> playerSyncInfo)
	{
		_playerSyncInfo = playerSyncInfo;
	}
	
	
	public override int GetId() 
	{
		return 501101;
	}
}