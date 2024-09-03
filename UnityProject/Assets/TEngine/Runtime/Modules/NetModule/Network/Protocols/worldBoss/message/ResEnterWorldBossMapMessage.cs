using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复参与世界boss message
 */
public class ResEnterWorldBossMapMessage : Message 
{
	//0:成功 1：参战人数达上限 2：活动未开始
	int _result;	
	//需要处理的被动技能列表
	List<int> _passSkillIdList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功 1：参战人数达上限 2：活动未开始
		SerializeUtils.WriteInt(stream, _result);
		//需要处理的被动技能列表
		SerializeUtils.WriteShort(stream, (short)_passSkillIdList.Count);

		foreach (var element in _passSkillIdList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功 1：参战人数达上限 2：活动未开始
		_result = SerializeUtils.ReadInt(stream);
		//需要处理的被动技能列表
		int _passSkillIdList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _passSkillIdList_length; ++i) 
		{
			_passSkillIdList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 0:成功 1：参战人数达上限 2：活动未开始
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * get 需要处理的被动技能列表
	 * @return 
	 */
	public List<int> GetPassSkillIdList()
	{
		return _passSkillIdList;
	}
	
	/**
	 * set 需要处理的被动技能列表
	 */
	public void SetPassSkillIdList(List<int> passSkillIdList)
	{
		_passSkillIdList = passSkillIdList;
	}
	
	
	public override int GetId() 
	{
		return 807105;
	}
}