using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队成员的角色信息(角色变更太频繁，尤其是全局buff变动，客户端又只是做展示，客户端来取) message
 */
public class ResGangMemberCharactersInfoMessage : Message 
{
	//番队玩家的id
	long _playerId;	
	//番队角色信息
	List<CharacterSyncInfo> _characterInfo = new List<CharacterSyncInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队玩家的id
		SerializeUtils.WriteLong(stream, _playerId);
		//番队角色信息
		SerializeUtils.WriteShort(stream, (short)_characterInfo.Count);

		foreach (var element in _characterInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队玩家的id
		_playerId = SerializeUtils.ReadLong(stream);
		//番队角色信息
		int _characterInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterInfo_length; ++i) 
		{
			_characterInfo.Add(SerializeUtils.ReadBean<CharacterSyncInfo>(stream));
		}
	}
	
	/**
	 * 番队玩家的id
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	/**
	 * get 番队角色信息
	 * @return 
	 */
	public List<CharacterSyncInfo> GetCharacterInfo()
	{
		return _characterInfo;
	}
	
	/**
	 * set 番队角色信息
	 */
	public void SetCharacterInfo(List<CharacterSyncInfo> characterInfo)
	{
		_characterInfo = characterInfo;
	}
	
	
	public override int GetId() 
	{
		return 109129;
	}
}