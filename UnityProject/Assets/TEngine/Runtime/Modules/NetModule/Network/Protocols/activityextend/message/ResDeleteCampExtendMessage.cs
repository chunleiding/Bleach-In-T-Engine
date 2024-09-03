using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 删除活动消息 message
 */
public class ResDeleteCampExtendMessage : Message 
{
	//活动ID列表
	List<int> _list = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//活动ID列表
		SerializeUtils.WriteShort(stream, (short)_list.Count);

		foreach (var element in _list)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//活动ID列表
		int _list_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _list_length; ++i) 
		{
			_list.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 活动ID列表
	 * @return 
	 */
	public List<int> GetList()
	{
		return _list;
	}
	
	/**
	 * set 活动ID列表
	 */
	public void SetList(List<int> list)
	{
		_list = list;
	}
	
	
	public override int GetId() 
	{
		return 823109;
	}
}