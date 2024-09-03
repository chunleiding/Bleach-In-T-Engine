using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵骸信息 message
 */
public class ResSoulSkeletonInfoMessage : Message 
{
	//灵骸id
	int _SkeletonId;	
	//激活技能列表
	List<int> _activeSkillList = new List<int>();
	//启用技能列表
	List<int> _enableSkillList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//灵骸id
		SerializeUtils.WriteInt(stream, _SkeletonId);
		//激活技能列表
		SerializeUtils.WriteShort(stream, (short)_activeSkillList.Count);

		foreach (var element in _activeSkillList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//启用技能列表
		SerializeUtils.WriteShort(stream, (short)_enableSkillList.Count);

		foreach (var element in _enableSkillList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//灵骸id
		_SkeletonId = SerializeUtils.ReadInt(stream);
		//激活技能列表
		int _activeSkillList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _activeSkillList_length; ++i) 
		{
			_activeSkillList.Add(SerializeUtils.ReadInt(stream));
		}
		//启用技能列表
		int _enableSkillList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _enableSkillList_length; ++i) 
		{
			_enableSkillList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 灵骸id
	 */
	public int SkeletonId
	{
		set { _SkeletonId = value; }
	    get { return _SkeletonId; }
	}
	
	/**
	 * get 激活技能列表
	 * @return 
	 */
	public List<int> GetActiveSkillList()
	{
		return _activeSkillList;
	}
	
	/**
	 * set 激活技能列表
	 */
	public void SetActiveSkillList(List<int> activeSkillList)
	{
		_activeSkillList = activeSkillList;
	}
	
	/**
	 * get 启用技能列表
	 * @return 
	 */
	public List<int> GetEnableSkillList()
	{
		return _enableSkillList;
	}
	
	/**
	 * set 启用技能列表
	 */
	public void SetEnableSkillList(List<int> enableSkillList)
	{
		_enableSkillList = enableSkillList;
	}
	
	
	public override int GetId() 
	{
		return 809100;
	}
}