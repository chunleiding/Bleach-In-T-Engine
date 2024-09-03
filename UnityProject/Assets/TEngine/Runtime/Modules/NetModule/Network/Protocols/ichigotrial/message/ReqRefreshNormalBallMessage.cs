using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求刷新普通球 message
 */
public class ReqRefreshNormalBallMessage : Message 
{
	//需要刷新球的道路列表
	List<int> _roadList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//需要刷新球的道路列表
		SerializeUtils.WriteShort(stream, (short)_roadList.Count);

		foreach (var element in _roadList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//需要刷新球的道路列表
		int _roadList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _roadList_length; ++i) 
		{
			_roadList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 需要刷新球的道路列表
	 * @return 
	 */
	public List<int> GetRoadList()
	{
		return _roadList;
	}
	
	/**
	 * set 需要刷新球的道路列表
	 */
	public void SetRoadList(List<int> roadList)
	{
		_roadList = roadList;
	}
	
	
	public override int GetId() 
	{
		return 825111;
	}
}