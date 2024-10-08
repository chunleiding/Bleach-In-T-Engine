using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 启用的魂共鸣技能id请求 message
 */
public class ReqSoulResonanceSelectMessage : Message 
{
	//玩家选中技能id
	List<int> _selectSkillIds = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家选中技能id
		SerializeUtils.WriteShort(stream, (short)_selectSkillIds.Count);

		foreach (var element in _selectSkillIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家选中技能id
		int _selectSkillIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _selectSkillIds_length; ++i) 
		{
			_selectSkillIds.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 玩家选中技能id
	 * @return 
	 */
	public List<int> GetSelectSkillIds()
	{
		return _selectSkillIds;
	}
	
	/**
	 * set 玩家选中技能id
	 */
	public void SetSelectSkillIds(List<int> selectSkillIds)
	{
		_selectSkillIds = selectSkillIds;
	}
	
	
	public override int GetId() 
	{
		return 111202;
	}
}