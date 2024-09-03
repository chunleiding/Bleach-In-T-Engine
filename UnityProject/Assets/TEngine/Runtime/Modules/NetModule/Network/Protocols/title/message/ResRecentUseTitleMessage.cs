using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 最近使用称号列表 message
 */
public class ResRecentUseTitleMessage : Message 
{
	//最近使用称号列表
	List<int> _recentUseList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//最近使用称号列表
		SerializeUtils.WriteShort(stream, (short)_recentUseList.Count);

		foreach (var element in _recentUseList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//最近使用称号列表
		int _recentUseList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _recentUseList_length; ++i) 
		{
			_recentUseList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 最近使用称号列表
	 * @return 
	 */
	public List<int> GetRecentUseList()
	{
		return _recentUseList;
	}
	
	/**
	 * set 最近使用称号列表
	 */
	public void SetRecentUseList(List<int> recentUseList)
	{
		_recentUseList = recentUseList;
	}
	
	
	public override int GetId() 
	{
		return 827109;
	}
}