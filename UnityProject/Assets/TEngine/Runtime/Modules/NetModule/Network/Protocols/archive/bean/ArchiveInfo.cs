using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 图鉴信息
 */
public class ArchiveInfo : IMessageSerialize 
{
	//图鉴id
	int _archiveId;	
	//图鉴状态
	int _archiveState;	
	//头像id
	int _characterId;	
	//标签Id
	int _tabId;	
	//如果是正常激活条件发0，道具激活条件发道具id
	int _specialConditionId;	
	//条件类型
	int _conditionType;	
	//1:角色;2:怪物
	int _rolesType;	
	//进度值
	int _progress;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//图鉴id
		SerializeUtils.WriteInt(stream, _archiveId);
		//图鉴状态
		SerializeUtils.WriteInt(stream, _archiveState);
		//头像id
		SerializeUtils.WriteInt(stream, _characterId);
		//标签Id
		SerializeUtils.WriteInt(stream, _tabId);
		//如果是正常激活条件发0，道具激活条件发道具id
		SerializeUtils.WriteInt(stream, _specialConditionId);
		//条件类型
		SerializeUtils.WriteInt(stream, _conditionType);
		//1:角色;2:怪物
		SerializeUtils.WriteInt(stream, _rolesType);
		//进度值
		SerializeUtils.WriteInt(stream, _progress);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//图鉴id
		_archiveId = SerializeUtils.ReadInt(stream);
		//图鉴状态
		_archiveState = SerializeUtils.ReadInt(stream);
		//头像id
		_characterId = SerializeUtils.ReadInt(stream);
		//标签Id
		_tabId = SerializeUtils.ReadInt(stream);
		//如果是正常激活条件发0，道具激活条件发道具id
		_specialConditionId = SerializeUtils.ReadInt(stream);
		//条件类型
		_conditionType = SerializeUtils.ReadInt(stream);
		//1:角色;2:怪物
		_rolesType = SerializeUtils.ReadInt(stream);
		//进度值
		_progress = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 图鉴id
	 */
	public int ArchiveId
	{
		set { _archiveId = value; }
	    get { return _archiveId; }
	}
	
	/**
	 * 图鉴状态
	 */
	public int ArchiveState
	{
		set { _archiveState = value; }
	    get { return _archiveState; }
	}
	
	/**
	 * 头像id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 标签Id
	 */
	public int TabId
	{
		set { _tabId = value; }
	    get { return _tabId; }
	}
	
	/**
	 * 如果是正常激活条件发0，道具激活条件发道具id
	 */
	public int SpecialConditionId
	{
		set { _specialConditionId = value; }
	    get { return _specialConditionId; }
	}
	
	/**
	 * 条件类型
	 */
	public int ConditionType
	{
		set { _conditionType = value; }
	    get { return _conditionType; }
	}
	
	/**
	 * 1:角色;2:怪物
	 */
	public int RolesType
	{
		set { _rolesType = value; }
	    get { return _rolesType; }
	}
	
	/**
	 * 进度值
	 */
	public int Progress
	{
		set { _progress = value; }
	    get { return _progress; }
	}
	
}