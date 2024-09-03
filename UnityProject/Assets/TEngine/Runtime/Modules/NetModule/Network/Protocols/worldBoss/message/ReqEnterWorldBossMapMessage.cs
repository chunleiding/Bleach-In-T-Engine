using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求参与世界boss message
 */
public class ReqEnterWorldBossMapMessage : Message 
{
	//出战角色
	int _charId;	
	//自己支援角色的角色的id
	List<int> _supportCharacterId = new List<int>();
	//其他支援角色的playerid
	List<long> _supportPlayerId = new List<long>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//出战角色
		SerializeUtils.WriteInt(stream, _charId);
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
		//出战角色
		_charId = SerializeUtils.ReadInt(stream);
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
	 * 出战角色
	 */
	public int CharId
	{
		set { _charId = value; }
	    get { return _charId; }
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
		return 807104;
	}
}