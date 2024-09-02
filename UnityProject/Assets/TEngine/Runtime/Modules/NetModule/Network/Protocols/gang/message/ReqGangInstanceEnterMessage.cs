using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 进入副本 message
 */
public class ReqGangInstanceEnterMessage : Message 
{
	//副本id
	int _instanceId;	
	//使用的角色的id
	int _characterId;	
	//自己支援角色的角色的id
	List<int> _supportCharacterId = new List<int>();
	//其他支援角色的playerid
	List<long> _supportPlayerId = new List<long>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//副本id
		SerializeUtils.WriteInt(stream, _instanceId);
		//使用的角色的id
		SerializeUtils.WriteInt(stream, _characterId);
		//自己支援角色的角色的id
		SerializeUtils.WriteShort(stream, (short)_supportCharacterId.Count);

		foreach (var element in _supportCharacterId)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//其他支援角色的playerid
		SerializeUtils.WriteShort(stream, (short)_supportPlayerId.Count);

		foreach (var element in _supportPlayerId)  
		{
			SerializeUtils.WriteLong(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//副本id
		_instanceId = SerializeUtils.ReadInt(stream);
		//使用的角色的id
		_characterId = SerializeUtils.ReadInt(stream);
		//自己支援角色的角色的id
		int _supportCharacterId_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _supportCharacterId_length; ++i) 
		{
			_supportCharacterId.Add(SerializeUtils.ReadInt(stream));
		}
		//其他支援角色的playerid
		int _supportPlayerId_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _supportPlayerId_length; ++i) 
		{
			_supportPlayerId.Add(SerializeUtils.ReadLong(stream));
		}
	}
	
	/**
	 * 副本id
	 */
	public int InstanceId
	{
		set { _instanceId = value; }
	    get { return _instanceId; }
	}
	
	/**
	 * 使用的角色的id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * get 自己支援角色的角色的id
	 * @return 
	 */
	public List<int> GetSupportCharacterId()
	{
		return _supportCharacterId;
	}
	
	/**
	 * set 自己支援角色的角色的id
	 */
	public void SetSupportCharacterId(List<int> supportCharacterId)
	{
		_supportCharacterId = supportCharacterId;
	}
	
	/**
	 * get 其他支援角色的playerid
	 * @return 
	 */
	public List<long> GetSupportPlayerId()
	{
		return _supportPlayerId;
	}
	
	/**
	 * set 其他支援角色的playerid
	 */
	public void SetSupportPlayerId(List<long> supportPlayerId)
	{
		_supportPlayerId = supportPlayerId;
	}
	
	
	public override int GetId() 
	{
		return 109217;
	}
}