using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队申请者详细信息
 */
public class GangApplyerDetailInfo : IMessageSerialize 
{
	//番队申请者基本信息
	GangApplyerInfo _applyerInfo;	
	//番队申请者角色列表
	List<CharacterSyncInfo> _characters = new List<CharacterSyncInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//番队申请者基本信息
		SerializeUtils.WriteBean(stream, _applyerInfo);
		//番队申请者角色列表
		SerializeUtils.WriteShort(stream, (short)_characters.Count);

		foreach (var element in _characters)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//番队申请者基本信息
		_applyerInfo = SerializeUtils.ReadBean<GangApplyerInfo>(stream);
		//番队申请者角色列表
		int _characters_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characters_length; ++i) 
		{
			_characters.Add(SerializeUtils.ReadBean<CharacterSyncInfo>(stream));
		}
	}
	
	/**
	 * 番队申请者基本信息
	 */
	public GangApplyerInfo ApplyerInfo
	{
		set { _applyerInfo = value; }
	    get { return _applyerInfo; }
	}
	
	/**
	 * get 番队申请者角色列表
	 * @return 
	 */
	public List<CharacterSyncInfo> GetCharacters()
	{
		return _characters;
	}
	
	/**
	 * set 番队申请者角色列表
	 */
	public void SetCharacters(List<CharacterSyncInfo> characters)
	{
		_characters = characters;
	}
	
}