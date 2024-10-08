using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 援护技能信息
 */
public class AssistSkillInfo : IMessageSerialize 
{
	//对应AssistSkillConfig表中的id
	List<int> _id = new List<int>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//对应AssistSkillConfig表中的id
		SerializeUtils.WriteShort(stream, (short)_id.Count);

		foreach (var element in _id)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//对应AssistSkillConfig表中的id
		int _id_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _id_length; ++i) 
		{
			_id.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 对应AssistSkillConfig表中的id
	 * @return 
	 */
	public List<int> GetId()
	{
		return _id;
	}
	
	/**
	 * set 对应AssistSkillConfig表中的id
	 */
	public void SetId(List<int> id)
	{
		_id = id;
	}
	
}